
namespace CSharp_AliyunTTS
{
    partial class Form_TTS_Single
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_TTS_Single));
            this.button_Compose = new System.Windows.Forms.Button();
            this.button_OpenFolder = new System.Windows.Forms.Button();
            this.label_ContentTitle = new System.Windows.Forms.Label();
            this.textBox_AudioContent = new System.Windows.Forms.TextBox();
            this.label_AudioName = new System.Windows.Forms.Label();
            this.textBox_AudioName = new System.Windows.Forms.TextBox();
            this.label_AudioPath = new System.Windows.Forms.Label();
            this.textBox_AudioPath = new System.Windows.Forms.TextBox();
            this.button_SetPath = new System.Windows.Forms.Button();
            this.label_VoiceQuality = new System.Windows.Forms.Label();
            this.comboBox_VoiceQuality = new System.Windows.Forms.ComboBox();
            this.label_Volume = new System.Windows.Forms.Label();
            this.trackBar_Volume = new System.Windows.Forms.TrackBar();
            this.label_VolumeValue = new System.Windows.Forms.Label();
            this.label_SpeechRateValue = new System.Windows.Forms.Label();
            this.trackBar_SpeechRate = new System.Windows.Forms.TrackBar();
            this.label_SpeechRate = new System.Windows.Forms.Label();
            this.label_PitchRateValue = new System.Windows.Forms.Label();
            this.trackBar_PitchRate = new System.Windows.Forms.TrackBar();
            this.label_PitchRate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Volume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_SpeechRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_PitchRate)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Compose
            // 
            this.button_Compose.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_Compose.Location = new System.Drawing.Point(192, 421);
            this.button_Compose.Name = "button_Compose";
            this.button_Compose.Size = new System.Drawing.Size(100, 28);
            this.button_Compose.TabIndex = 0;
            this.button_Compose.Text = "合成";
            this.button_Compose.UseVisualStyleBackColor = true;
            this.button_Compose.Click += new System.EventHandler(this.button_Compose_Click);
            // 
            // button_OpenFolder
            // 
            this.button_OpenFolder.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_OpenFolder.Location = new System.Drawing.Point(192, 465);
            this.button_OpenFolder.Name = "button_OpenFolder";
            this.button_OpenFolder.Size = new System.Drawing.Size(100, 28);
            this.button_OpenFolder.TabIndex = 1;
            this.button_OpenFolder.Text = "打开文件夹";
            this.button_OpenFolder.UseVisualStyleBackColor = true;
            this.button_OpenFolder.Click += new System.EventHandler(this.button_OpenFolder_Click);
            // 
            // label_ContentTitle
            // 
            this.label_ContentTitle.AutoSize = true;
            this.label_ContentTitle.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_ContentTitle.Location = new System.Drawing.Point(45, 31);
            this.label_ContentTitle.Name = "label_ContentTitle";
            this.label_ContentTitle.Size = new System.Drawing.Size(105, 14);
            this.label_ContentTitle.TabIndex = 2;
            this.label_ContentTitle.Text = "语音文本内容：";
            // 
            // textBox_AudioContent
            // 
            this.textBox_AudioContent.Location = new System.Drawing.Point(158, 29);
            this.textBox_AudioContent.Multiline = true;
            this.textBox_AudioContent.Name = "textBox_AudioContent";
            this.textBox_AudioContent.Size = new System.Drawing.Size(274, 120);
            this.textBox_AudioContent.TabIndex = 3;
            // 
            // label_AudioName
            // 
            this.label_AudioName.AutoSize = true;
            this.label_AudioName.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_AudioName.Location = new System.Drawing.Point(73, 168);
            this.label_AudioName.Name = "label_AudioName";
            this.label_AudioName.Size = new System.Drawing.Size(77, 14);
            this.label_AudioName.TabIndex = 4;
            this.label_AudioName.Text = "语音名称：";
            // 
            // textBox_AudioName
            // 
            this.textBox_AudioName.Location = new System.Drawing.Point(158, 166);
            this.textBox_AudioName.Name = "textBox_AudioName";
            this.textBox_AudioName.Size = new System.Drawing.Size(174, 21);
            this.textBox_AudioName.TabIndex = 5;
            // 
            // label_AudioPath
            // 
            this.label_AudioPath.AutoSize = true;
            this.label_AudioPath.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_AudioPath.Location = new System.Drawing.Point(45, 355);
            this.label_AudioPath.Name = "label_AudioPath";
            this.label_AudioPath.Size = new System.Drawing.Size(105, 14);
            this.label_AudioPath.TabIndex = 6;
            this.label_AudioPath.Text = "语音文件路径：";
            // 
            // textBox_AudioPath
            // 
            this.textBox_AudioPath.Location = new System.Drawing.Point(158, 353);
            this.textBox_AudioPath.Name = "textBox_AudioPath";
            this.textBox_AudioPath.Size = new System.Drawing.Size(197, 21);
            this.textBox_AudioPath.TabIndex = 7;
            // 
            // button_SetPath
            // 
            this.button_SetPath.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_SetPath.Location = new System.Drawing.Point(372, 349);
            this.button_SetPath.Name = "button_SetPath";
            this.button_SetPath.Size = new System.Drawing.Size(60, 30);
            this.button_SetPath.TabIndex = 8;
            this.button_SetPath.Text = "浏览";
            this.button_SetPath.UseVisualStyleBackColor = true;
            this.button_SetPath.Click += new System.EventHandler(this.button_SetPath_Click);
            // 
            // label_VoiceQuality
            // 
            this.label_VoiceQuality.AutoSize = true;
            this.label_VoiceQuality.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_VoiceQuality.Location = new System.Drawing.Point(73, 212);
            this.label_VoiceQuality.Name = "label_VoiceQuality";
            this.label_VoiceQuality.Size = new System.Drawing.Size(77, 14);
            this.label_VoiceQuality.TabIndex = 9;
            this.label_VoiceQuality.Text = "选择音色：";
            // 
            // comboBox_VoiceQuality
            // 
            this.comboBox_VoiceQuality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_VoiceQuality.FormattingEnabled = true;
            this.comboBox_VoiceQuality.Location = new System.Drawing.Point(158, 210);
            this.comboBox_VoiceQuality.Name = "comboBox_VoiceQuality";
            this.comboBox_VoiceQuality.Size = new System.Drawing.Size(174, 20);
            this.comboBox_VoiceQuality.TabIndex = 10;
            this.comboBox_VoiceQuality.SelectedIndexChanged += new System.EventHandler(this.comboBox_VoiceQuality_SelectedIndexChanged);
            // 
            // label_Volume
            // 
            this.label_Volume.AutoSize = true;
            this.label_Volume.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Volume.Location = new System.Drawing.Point(73, 259);
            this.label_Volume.Name = "label_Volume";
            this.label_Volume.Size = new System.Drawing.Size(49, 14);
            this.label_Volume.TabIndex = 11;
            this.label_Volume.Text = "音量：";
            // 
            // trackBar_Volume
            // 
            this.trackBar_Volume.Location = new System.Drawing.Point(64, 295);
            this.trackBar_Volume.Maximum = 100;
            this.trackBar_Volume.Name = "trackBar_Volume";
            this.trackBar_Volume.Size = new System.Drawing.Size(104, 45);
            this.trackBar_Volume.TabIndex = 12;
            this.trackBar_Volume.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar_Volume.Scroll += new System.EventHandler(this.trackBar_Volume_Scroll);
            // 
            // label_VolumeValue
            // 
            this.label_VolumeValue.AutoSize = true;
            this.label_VolumeValue.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_VolumeValue.Location = new System.Drawing.Point(120, 258);
            this.label_VolumeValue.Name = "label_VolumeValue";
            this.label_VolumeValue.Size = new System.Drawing.Size(0, 16);
            this.label_VolumeValue.TabIndex = 13;
            // 
            // label_SpeechRateValue
            // 
            this.label_SpeechRateValue.AutoSize = true;
            this.label_SpeechRateValue.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_SpeechRateValue.Location = new System.Drawing.Point(248, 258);
            this.label_SpeechRateValue.Name = "label_SpeechRateValue";
            this.label_SpeechRateValue.Size = new System.Drawing.Size(0, 16);
            this.label_SpeechRateValue.TabIndex = 16;
            // 
            // trackBar_SpeechRate
            // 
            this.trackBar_SpeechRate.Location = new System.Drawing.Point(192, 295);
            this.trackBar_SpeechRate.Maximum = 500;
            this.trackBar_SpeechRate.Minimum = -500;
            this.trackBar_SpeechRate.Name = "trackBar_SpeechRate";
            this.trackBar_SpeechRate.Size = new System.Drawing.Size(104, 45);
            this.trackBar_SpeechRate.TabIndex = 15;
            this.trackBar_SpeechRate.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar_SpeechRate.Value = -500;
            this.trackBar_SpeechRate.Scroll += new System.EventHandler(this.trackBar_SpeechRate_Scroll);
            // 
            // label_SpeechRate
            // 
            this.label_SpeechRate.AutoSize = true;
            this.label_SpeechRate.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_SpeechRate.Location = new System.Drawing.Point(201, 259);
            this.label_SpeechRate.Name = "label_SpeechRate";
            this.label_SpeechRate.Size = new System.Drawing.Size(49, 14);
            this.label_SpeechRate.TabIndex = 14;
            this.label_SpeechRate.Text = "语速：";
            // 
            // label_PitchRateValue
            // 
            this.label_PitchRateValue.AutoSize = true;
            this.label_PitchRateValue.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_PitchRateValue.Location = new System.Drawing.Point(384, 258);
            this.label_PitchRateValue.Name = "label_PitchRateValue";
            this.label_PitchRateValue.Size = new System.Drawing.Size(0, 16);
            this.label_PitchRateValue.TabIndex = 19;
            // 
            // trackBar_PitchRate
            // 
            this.trackBar_PitchRate.Location = new System.Drawing.Point(328, 295);
            this.trackBar_PitchRate.Maximum = 500;
            this.trackBar_PitchRate.Minimum = -500;
            this.trackBar_PitchRate.Name = "trackBar_PitchRate";
            this.trackBar_PitchRate.Size = new System.Drawing.Size(104, 45);
            this.trackBar_PitchRate.TabIndex = 18;
            this.trackBar_PitchRate.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar_PitchRate.Value = -500;
            this.trackBar_PitchRate.Scroll += new System.EventHandler(this.trackBar_PitchRate_Scroll);
            // 
            // label_PitchRate
            // 
            this.label_PitchRate.AutoSize = true;
            this.label_PitchRate.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_PitchRate.Location = new System.Drawing.Point(337, 259);
            this.label_PitchRate.Name = "label_PitchRate";
            this.label_PitchRate.Size = new System.Drawing.Size(49, 14);
            this.label_PitchRate.TabIndex = 17;
            this.label_PitchRate.Text = "语调：";
            // 
            // Form_TTS_Single
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 501);
            this.Controls.Add(this.label_PitchRateValue);
            this.Controls.Add(this.trackBar_PitchRate);
            this.Controls.Add(this.label_PitchRate);
            this.Controls.Add(this.label_SpeechRateValue);
            this.Controls.Add(this.trackBar_SpeechRate);
            this.Controls.Add(this.label_SpeechRate);
            this.Controls.Add(this.label_VolumeValue);
            this.Controls.Add(this.trackBar_Volume);
            this.Controls.Add(this.label_Volume);
            this.Controls.Add(this.comboBox_VoiceQuality);
            this.Controls.Add(this.label_VoiceQuality);
            this.Controls.Add(this.button_SetPath);
            this.Controls.Add(this.textBox_AudioPath);
            this.Controls.Add(this.label_AudioPath);
            this.Controls.Add(this.textBox_AudioName);
            this.Controls.Add(this.label_AudioName);
            this.Controls.Add(this.textBox_AudioContent);
            this.Controls.Add(this.label_ContentTitle);
            this.Controls.Add(this.button_OpenFolder);
            this.Controls.Add(this.button_Compose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_TTS_Single";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "阿里云单条语音合成器";
            this.Load += new System.EventHandler(this.Form_TTSLauncher_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Volume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_SpeechRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_PitchRate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Compose;
        private System.Windows.Forms.Button button_OpenFolder;
        private System.Windows.Forms.Label label_ContentTitle;
        private System.Windows.Forms.TextBox textBox_AudioContent;
        private System.Windows.Forms.Label label_AudioName;
        private System.Windows.Forms.TextBox textBox_AudioName;
        private System.Windows.Forms.Label label_AudioPath;
        private System.Windows.Forms.TextBox textBox_AudioPath;
        private System.Windows.Forms.Button button_SetPath;
        private System.Windows.Forms.Label label_VoiceQuality;
        private System.Windows.Forms.ComboBox comboBox_VoiceQuality;
        private System.Windows.Forms.Label label_Volume;
        private System.Windows.Forms.TrackBar trackBar_Volume;
        private System.Windows.Forms.Label label_VolumeValue;
        private System.Windows.Forms.Label label_SpeechRateValue;
        private System.Windows.Forms.TrackBar trackBar_SpeechRate;
        private System.Windows.Forms.Label label_SpeechRate;
        private System.Windows.Forms.Label label_PitchRateValue;
        private System.Windows.Forms.TrackBar trackBar_PitchRate;
        private System.Windows.Forms.Label label_PitchRate;
    }
}

