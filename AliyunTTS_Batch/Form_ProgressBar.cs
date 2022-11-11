using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_AliyunTTS_Batch
{
    public partial class Form_ProgressBar : Form
    {
        public Form_ProgressBar()
        {
            InitializeComponent();
        }

        private void Form_Prompt_Load(object sender, EventArgs e)
        {
            Owner.Enabled = false;

            int resultX = Owner.Location.X + (Owner.Size.Width-Size.Width)/2;
            int resultY = Owner.Location.Y + (Owner.Size.Height - Size.Height) / 2;
            Location = new Point(resultX, resultY);
        }

        private void Form_Prompt_Closed(object sender, FormClosedEventArgs e)
        {
            Owner.Enabled = true;
        }

        /// <summary>
        /// 设置进度条
        /// </summary>
        /// <param name="minValue">最小值</param>
        /// <param name="maxValue">最大值</param>
        public void SetProgress(int minValue,int maxValue)
        {
            progressBar_TTS.Maximum = maxValue;
            progressBar_TTS.Minimum = minValue;
            progressBar_TTS.Value = minValue;
            label_Progress.Text = $"{minValue}/{maxValue}";

            Application.DoEvents();
        }

        /// <summary>
        /// 更新进度
        /// </summary>
        /// <param name="totalCount">总数</param>
        public void UpdateProgress(int finishCount)
        {
            progressBar_TTS.PerformStep();

            label_Progress.Text = $"{finishCount}/{progressBar_TTS.Maximum}";

            Application.DoEvents();
        }
    }
}
