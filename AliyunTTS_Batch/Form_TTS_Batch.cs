using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using LitJson;
using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Exceptions;
using Aliyun.Acs.Core.Profile;
using NPOI.SS.UserModel;
using NPOI.HSSF.UserModel;
using NPOI.XSSF.UserModel;
using System.Runtime.InteropServices;

namespace CSharp_AliyunTTS_Batch
{
    public partial class Form_TTS_Batch : Form
    {
        /// <summary>
        /// 接口url
        /// </summary>
        private string url = "http://nls-gateway.aliyuncs.com/stream/v1/tts";

        private string voiceOuputPath;              //语音输出路径
        private string voiceName = "思琪";           //音色
        private int audioIndex = 0;                 //语音索引

        private UserVerifyInfo userVerifyInfo;      //用户验证信息

        private Form_ProgressBar progressForm;      //进度Form

        Dictionary<string, string> voiceMap;        //语音质量键值对
        List<AudioInfo> audioInfoList;

        public Form_TTS_Batch()
        {
            InitializeComponent();
        }

        private void Form_TTS_Batch_Load(object sender, EventArgs e) 
        {
            InitOpertion();
        }

        /// <summary>
        /// 初始化操作
        /// </summary>
        private void InitOpertion()
        {
            voiceMap = new Dictionary<string, string>();
            string configPath = Directory.GetCurrentDirectory() + "/Config";
            string voiceQualityConfigPath = configPath + "/VoiceQuality.xlsx";

            //不设置语音文件路径情况下 默认为根目录语音输出文件夹
            voiceOuputPath = Directory.GetCurrentDirectory() + @"\OutputAudio";

            if (!Directory.Exists(voiceOuputPath)) { Directory.CreateDirectory(voiceOuputPath); }

            //遍历配置表 动态对语音质量键值对赋值
            FileStream fs = new FileStream(voiceQualityConfigPath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            IWorkbook workbook = null;

            string extension = Path.GetExtension(voiceQualityConfigPath);

            switch (extension)
            {
                case ".xls": workbook = new HSSFWorkbook(fs); break;
                case ".xlsx": workbook = new XSSFWorkbook(fs); break;
            }

            ISheet sheet = workbook.GetSheet("VoiceQuality");

            for (int rowNum = 1; rowNum <= sheet.LastRowNum; rowNum++)
            {
                IRow row = sheet.GetRow(rowNum);
                ICell cell_Name = row.GetCell(0);
                ICell cell_Voice = row.GetCell(1);

                voiceMap.Add(cell_Name.ToString(), cell_Voice.ToString());
            }

            //初始化音色下拉框
            string[] voiceNameArray = voiceMap.Select(voiceInfo => voiceInfo.Key).ToArray();
            comboBox_VoiceQuality.Items.AddRange(voiceNameArray);

            comboBox_VoiceQuality.Text = voiceName;

            //初始化音量、语速、语调
            label_VolumeValue.Text = "50";
            label_SpeechRateValue.Text = "0";
            label_PitchRateValue.Text = "0";

            trackBar_Volume.Value = 50;
            trackBar_SpeechRate.Value = 0;
            trackBar_PitchRate.Value = 0;

            //初始化用户验证信息
            StreamReader reader = new StreamReader(configPath + "/UserVerify.json", Encoding.UTF8);
            userVerifyInfo = JsonMapper.ToObject<UserVerifyInfo>(reader.ReadToEnd());
        }

        // 按钮事件-选择Excel
        private void button_SelectExcel_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Excel文件|*.xls;*.xlsx";
            dialog.Title = "选择Excel表格";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                textBox_ExcelPath.Text = dialog.FileName;
            }
        }

        //Excel区域拖拽-开始
        private void listView_DragExcel_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Move;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        //Excel区域拖拽-结束
        private void listView_DragExcel_DragDrop(object sender, DragEventArgs e)
        {
            string filePath = ((string[])e.Data.GetData(DataFormats.FileDrop))[0];

            if (Path.GetExtension(filePath) == ".xls" || Path.GetExtension(filePath) == ".xlsx")
            {
                textBox_ExcelPath.Text = filePath;

                pictureBox_Excel.Visible = true;
                label_DragPrompt1.Visible = false;
                label_DragPrompt2.Visible = false;
            }
            else
            {
                textBox_ExcelPath.Text = "";

                pictureBox_Excel.Visible = false;
                label_DragPrompt1.Visible = true;
                label_DragPrompt2.Visible = true;

                MessageBoxButtons messButton = MessageBoxButtons.OK;
                MessageBoxEx.Show(this, "请拖拽入.xls/.xlsx文件", "警告", messButton);
                return;
            }
        }

        //音色下拉框事件
        private void comboBox_VoiceQuality_SelectedIndexChanged(object sender, EventArgs e)
        {
            voiceName = comboBox_VoiceQuality.Text;
        }

        //按钮事件-设置批处理语音文件路径
        private void button_SetPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog path = new FolderBrowserDialog();
            path.ShowDialog();
            textBox_AudioPath.Text = path.SelectedPath;
            voiceOuputPath = path.SelectedPath;
        }

        // 按钮事件-合成
        private void button_Compose_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_ExcelPath.Text))
            {
                MessageBoxButtons messButton = MessageBoxButtons.OK;
                MessageBoxEx.Show(this, "Excel路径不能为空", "警告", messButton);
                return;
            }

            //初始化语音索引为0
            audioIndex = 0;

            //初始化语音信息列表
            audioInfoList = new List<AudioInfo>();

            //从Excel路径读取表格并解析
            string excelPath = textBox_ExcelPath.Text;
            FileInfo fileInfo = new FileInfo(excelPath);
            FileStream fileStream = fileInfo.Open(FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            IWorkbook workbook = Path.GetExtension(excelPath) == ".xls" ? (IWorkbook)new HSSFWorkbook(fileStream) : (IWorkbook)new XSSFWorkbook(fileStream);

            ISheet sheet = workbook.GetSheet("AudioData");

            for (int rowNum = 3; rowNum <= sheet.LastRowNum; rowNum++)
            {
                ICell audioName = sheet.GetRow(rowNum).GetCell(2);
                ICell audioContent = sheet.GetRow(rowNum).GetCell(4);

                audioInfoList.Add(new AudioInfo(audioName.ToString(), audioContent.ToString()));
            }

            progressForm = new Form_ProgressBar();
            progressForm.SetProgress(0, audioInfoList.Count);
            progressForm.Show(this);

            ComposeAudio();
        }

        /// <summary>
        /// 语音合成
        /// 递归
        /// </summary>
        public void ComposeAudio()
        {
            if (audioIndex < 0) return;

            progressForm.UpdateProgress(audioIndex);
            TaskWait(0.5f);

            if (audioIndex <= audioInfoList.Count - 1)
            {
                AudioInfo audioInfo = audioInfoList[audioIndex];
                SendJsonInfo sendJsonInfo = new SendJsonInfo()
                {
                    appkey = userVerifyInfo.appkey,
                    text = audioInfo.Content,
                    token = GetToken(),
                    format = "wav",
                    voice = voiceMap[voiceName],
                    volume = trackBar_Volume.Value,
                    speech_rate = trackBar_SpeechRate.Value,
                    pitch_rate = trackBar_PitchRate.Value
                };

                HttpPost(url, JsonMapper.ToJson(sendJsonInfo),
                    dataCallBack: (data) => SaveAudioData(data, voiceOuputPath + @"\" + $"/{audioInfo.Name}.wav",
                    () =>
                    {
                        audioIndex++;
                        ComposeAudio();
                    }));
            }
            else
            {
                audioIndex = 0;
                progressForm.Close();
                MessageBoxButtons messButton = MessageBoxButtons.OK;
                MessageBoxEx.Show(this, "转化成功", "恭喜", messButton);
            }
        }

        private void TaskWait(float time)
        {
            if (time <= 0) return;

            DateTime nowTimer = DateTime.Now;
            double interval = 0;
            while (interval < time)
            {
                TimeSpan spand = DateTime.Now - nowTimer;
                interval = spand.TotalSeconds;
            }
        }

        //按钮事件-打开输出语音所在文件夹
        private void button_OpenFolder_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", voiceOuputPath);
        }

        //滑动条事件
        private void trackBar_Volume_Scroll(object sender, EventArgs e)
        {
            label_VolumeValue.Text = trackBar_Volume.Value.ToString();
        }

        private void trackBar_SpeechRate_Scroll(object sender, EventArgs e)
        {
            label_SpeechRateValue.Text = trackBar_SpeechRate.Value.ToString();
        }

        private void trackBar_PitchRate_Scroll(object sender, EventArgs e)
        {
            label_PitchRateValue.Text = trackBar_PitchRate.Value.ToString();
        }

        /// <summary>
        /// 保存语音数据文件到本地
        /// </summary>
        /// <param name="data">二进制</param>
        /// <param name="filePath">路径</param>
        private void SaveAudioData(byte[] data, string filePath, Action callBack)
        {
            try
            {
                FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.Write, FileShare.ReadWrite);
                fs.Write(data, 0, data.Length);
                fs.Flush();
                fs.Close();

                callBack?.Invoke();
            }
            catch (Exception ex)
            {
                progressForm.Close();
                MessageBoxButtons messButton = MessageBoxButtons.OK;
                MessageBoxEx.Show(this, ex.ToString(), "警告", messButton);
            }
        }

        /// <summary>
        /// 获取Token鉴权
        /// </summary>
        /// <returns></returns>
        private string GetToken()
        {
            IClientProfile profile = DefaultProfile.GetProfile(
                "cn-shanghai",
                userVerifyInfo.accessKey,
                userVerifyInfo.secret);
            DefaultAcsClient client = new DefaultAcsClient(profile);

            try
            {
                CommonRequest request = new CommonRequest();
                request.Domain = "nls-meta.cn-shanghai.aliyuncs.com";
                request.Version = "2019-02-28";

                request.Action = "CreateToken";

                CommonResponse response = client.GetCommonResponse(request);

                Console.WriteLine(response.Data);
                ReceiveJsonInfo jsonInfo = LitJson.JsonMapper.ToObject<ReceiveJsonInfo>(response.Data);
                if (jsonInfo.Token != null)
                {
                    return jsonInfo.Token.Id;
                }
                else
                {
                    MessageBoxButtons messButton = MessageBoxButtons.OK;
                    MessageBoxEx.Show(this, "用户验证配置信息有误!", "警告", messButton);
                    progressForm.Close();
                }
            }
            catch (ServerException ex)
            {
                MessageBoxButtons messButton = MessageBoxButtons.OK;
                MessageBoxEx.Show(this, ex.Message, "警告", messButton);
            }
            catch (ClientException ex)
            {
                MessageBoxButtons messButton = MessageBoxButtons.OK;
                MessageBoxEx.Show(this, ex.Message, "警告", messButton);
            }

            return "";
        }

        /// <summary>
        /// HttpWebRequest Post请求
        /// </summary>
        /// <param name="url">接口地址</param>
        /// <param name="requestParam">请求参数</param>
        /// <param name="mimeType">MIME类型</param>
        /// <param name="headerDic">头文件字典</param>
        /// <param name="textCallBack">文本内容回调</param>
        /// <param name="dataCallBack">二进制回调</param>
        /// <param name="failCallBack">请求失败回调</param>
        /// <returns></returns>
        private void HttpPost(string url, string requestParam, Dictionary<string, string> headerDic = null, Action<string> textCallBack = null, Action<byte[]> dataCallBack = null, Action failCallBack = null)
        {
            HttpWebRequest request = (HttpWebRequest)System.Net.WebRequest.Create(url);

            if (headerDic != null && headerDic.Count >= 1)
            {
                foreach (var item in headerDic)
                {
                    request.Headers[item.Key] = item.Value;
                }
            }

            request.Method = "POST";
            request.ContentType = "application/json;charset=utf-8";

            Regex reg = new Regex(@"(?i)\\[uU]([0-9a-f]{4})");
            requestParam = reg.Replace(requestParam, delegate (Match m) { return ((char)Convert.ToInt32(m.Groups[1].Value, 16)).ToString(); });

            byte[] jsonData = Encoding.UTF8.GetBytes(requestParam);
            request.ContentLength = jsonData.Length;

            try
            {
                Stream reqStream = request.GetRequestStream();
                reqStream.Write(jsonData, 0, jsonData.Length);
                reqStream.Close();

                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                Stream responsStream = response.GetResponseStream();


                MemoryStream ms = new MemoryStream();
                byte[] data = new byte[1024];
                while (true)
                {
                    int count = responsStream.Read(data, 0, 1024);

                    if (count == 0) break;
                    ms.Write(data, 0, count);
                }

                string text = Encoding.UTF8.GetString(ms.ToArray());

                textCallBack?.Invoke(text);
                dataCallBack?.Invoke(ms.ToArray());

                ms.Close();
                request.Abort();
                response.Close();
            }
            catch (WebException ex)
            {
                Console.WriteLine(ex.Message);
                failCallBack?.Invoke();
            }
        }
    }

    /// <summary>
    /// 语音信息
    /// </summary>
    public class AudioInfo
    {
        public string Name;        //语音名称
        public string Content;     //语音内容

        public AudioInfo(string name, string content)
        {
            Name = name;
            Content = content;
        }
    }

    /// <summary>
    /// 用户验证信息
    /// </summary>
    public class UserVerifyInfo
    {
        public string accessKey;
        public string secret;
        public string appkey;
    }

    /// <summary>
    /// 接收Json信息
    /// </summary>
    public class ReceiveJsonInfo
    {
        public string ErrMsg;
        public TokenInfo Token;

        public class TokenInfo
        {
            public string UserId;
            public string Id;
            public int ExpireTime;
        }
    }

    /// <summary>
    /// 发送Json信息
    /// </summary>
    public class SendJsonInfo
    {
        public string appkey;           //项目appkey
        public string text;             //待合成的文本
        public string token;            //token令牌
        public string format;           //音频编码格式
        public string voice;            //发音人
        public int volume;              //音量
        public int speech_rate;         //语速
        public int pitch_rate;          //语调
    }

    //弹出框重写
    public class MessageBoxEx
    {
        private static IWin32Window _owner;
        private static HookProc _hookProc;
        private static IntPtr _hHook;

        public static DialogResult Show(string text)
        {
            Initialize();
            return MessageBox.Show(text);
        }

        public static DialogResult Show(string text, string caption)
        {
            Initialize();
            return MessageBox.Show(text, caption);
        }

        public static DialogResult Show(string text, string caption, MessageBoxButtons buttons)
        {
            Initialize();
            return MessageBox.Show(text, caption, buttons);
        }

        public static DialogResult Show(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon)
        {
            Initialize();
            return MessageBox.Show(text, caption, buttons, icon);
        }

        public static DialogResult Show(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon, MessageBoxDefaultButton defButton)
        {
            Initialize();
            return MessageBox.Show(text, caption, buttons, icon, defButton);
        }

        public static DialogResult Show(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon, MessageBoxDefaultButton defButton, MessageBoxOptions options)
        {
            Initialize();
            return MessageBox.Show(text, caption, buttons, icon, defButton, options);
        }

        public static DialogResult Show(IWin32Window owner, string text)
        {
            _owner = owner;
            Initialize();
            return MessageBox.Show(owner, text);
        }

        public static DialogResult Show(IWin32Window owner, string text, string caption)
        {
            _owner = owner;
            Initialize();
            return MessageBox.Show(owner, text, caption);
        }

        public static DialogResult Show(IWin32Window owner, string text, string caption, MessageBoxButtons buttons)
        {
            _owner = owner;
            Initialize();
            return MessageBox.Show(owner, text, caption, buttons);
        }

        public static DialogResult Show(IWin32Window owner, string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon)
        {
            _owner = owner;
            Initialize();
            return MessageBox.Show(owner, text, caption, buttons, icon);
        }

        public static DialogResult Show(IWin32Window owner, string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon, MessageBoxDefaultButton defButton)
        {
            _owner = owner;
            Initialize();
            return MessageBox.Show(owner, text, caption, buttons, icon, defButton);
        }

        public static DialogResult Show(IWin32Window owner, string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon, MessageBoxDefaultButton defButton, MessageBoxOptions options)
        {
            _owner = owner;
            Initialize();
            return MessageBox.Show(owner, text, caption, buttons, icon,
                                   defButton, options);
        }

        public delegate IntPtr HookProc(int nCode, IntPtr wParam, IntPtr lParam);

        public delegate void TimerProc(IntPtr hWnd, uint uMsg, UIntPtr nIDEvent, uint dwTime);

        public const int WH_CALLWNDPROCRET = 12;

        public enum CbtHookAction : int
        {
            HCBT_MOVESIZE = 0,
            HCBT_MINMAX = 1,
            HCBT_QS = 2,
            HCBT_CREATEWND = 3,
            HCBT_DESTROYWND = 4,
            HCBT_ACTIVATE = 5,
            HCBT_CLICKSKIPPED = 6,
            HCBT_KEYSKIPPED = 7,
            HCBT_SYSCOMMAND = 8,
            HCBT_SETFOCUS = 9
        }

        [DllImport("user32.dll")]
        private static extern bool GetWindowRect(IntPtr hWnd, ref Rectangle lpRect);

        [DllImport("user32.dll")]
        private static extern int MoveWindow(IntPtr hWnd, int X, int Y, int nWidth, int nHeight, bool bRepaint);

        [DllImport("User32.dll")]
        public static extern UIntPtr SetTimer(IntPtr hWnd, UIntPtr nIDEvent, uint uElapse, TimerProc lpTimerFunc);

        [DllImport("User32.dll")]
        public static extern IntPtr SendMessage(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);

        [DllImport("user32.dll")]
        public static extern IntPtr SetWindowsHookEx(int idHook, HookProc lpfn, IntPtr hInstance, int threadId);

        [DllImport("user32.dll")]
        public static extern int UnhookWindowsHookEx(IntPtr idHook);

        [DllImport("user32.dll")]
        public static extern IntPtr CallNextHookEx(IntPtr idHook, int nCode, IntPtr wParam, IntPtr lParam);

        [DllImport("user32.dll")]
        public static extern int GetWindowTextLength(IntPtr hWnd);

        [DllImport("user32.dll")]
        public static extern int GetWindowText(IntPtr hWnd, StringBuilder text, int maxLength);

        [DllImport("user32.dll")]
        public static extern int EndDialog(IntPtr hDlg, IntPtr nResult);

        [StructLayout(LayoutKind.Sequential)]
        public struct CWPRETSTRUCT
        {
            public IntPtr lResult;
            public IntPtr lParam;
            public IntPtr wParam;
            public uint message;
            public IntPtr hwnd;
        };

        static MessageBoxEx()
        {
            _hookProc = new HookProc(MessageBoxHookProc);
            _hHook = IntPtr.Zero;
        }

        private static void Initialize()
        {
            if (_hHook != IntPtr.Zero)
            {
                throw new NotSupportedException("multiple calls are not supported");
            }

            if (_owner != null)
            {
                _hHook = SetWindowsHookEx(WH_CALLWNDPROCRET, _hookProc, IntPtr.Zero, AppDomain.GetCurrentThreadId());
            }
        }

        private static IntPtr MessageBoxHookProc(int nCode, IntPtr wParam, IntPtr lParam)
        {
            if (nCode < 0)
            {
                return CallNextHookEx(_hHook, nCode, wParam, lParam);
            }

            CWPRETSTRUCT msg = (CWPRETSTRUCT)Marshal.PtrToStructure(lParam, typeof(CWPRETSTRUCT));
            IntPtr hook = _hHook;

            if (msg.message == (int)CbtHookAction.HCBT_ACTIVATE)
            {
                try
                {
                    CenterWindow(msg.hwnd);
                }
                finally
                {
                    UnhookWindowsHookEx(_hHook);
                    _hHook = IntPtr.Zero;
                }
            }

            return CallNextHookEx(hook, nCode, wParam, lParam);
        }

        private static void CenterWindow(IntPtr hChildWnd)
        {
            Rectangle recChild = new Rectangle(0, 0, 0, 0);
            bool success = GetWindowRect(hChildWnd, ref recChild);

            int width = recChild.Width - recChild.X;
            int height = recChild.Height - recChild.Y;

            Rectangle recParent = new Rectangle(0, 0, 0, 0);
            success = GetWindowRect(_owner.Handle, ref recParent);

            Point ptCenter = new Point(0, 0);
            ptCenter.X = recParent.X + ((recParent.Width - recParent.X) / 2);
            ptCenter.Y = recParent.Y + ((recParent.Height - recParent.Y) / 2);

            Point ptStart = new Point(0, 0);
            ptStart.X = (ptCenter.X - (width / 2));
            ptStart.Y = (ptCenter.Y - (height / 2));

            ptStart.X = (ptStart.X < 0) ? 0 : ptStart.X;
            ptStart.Y = (ptStart.Y < 0) ? 0 : ptStart.Y;

            int result = MoveWindow(hChildWnd, ptStart.X, ptStart.Y, width, height, false);
        }
    }
}
