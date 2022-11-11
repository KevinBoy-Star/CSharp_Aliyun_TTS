
namespace CSharp_AliyunTTS_Batch
{
    partial class Form_TTS_Batch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_TTS_Batch));
            this.button_OpenFolder = new System.Windows.Forms.Button();
            this.button_Compose = new System.Windows.Forms.Button();
            this.comboBox_VoiceQuality = new System.Windows.Forms.ComboBox();
            this.label_VoiceQuality = new System.Windows.Forms.Label();
            this.label_PitchRateValue = new System.Windows.Forms.Label();
            this.trackBar_PitchRate = new System.Windows.Forms.TrackBar();
            this.label_PitchRate = new System.Windows.Forms.Label();
            this.label_SpeechRateValue = new System.Windows.Forms.Label();
            this.trackBar_SpeechRate = new System.Windows.Forms.TrackBar();
            this.label_SpeechRate = new System.Windows.Forms.Label();
            this.label_VolumeValue = new System.Windows.Forms.Label();
            this.trackBar_Volume = new System.Windows.Forms.TrackBar();
            this.label_Volume = new System.Windows.Forms.Label();
            this.button_SetPath = new System.Windows.Forms.Button();
            this.textBox_AudioPath = new System.Windows.Forms.TextBox();
            this.label_AudioPath = new System.Windows.Forms.Label();
            this.button_SelectExcel = new System.Windows.Forms.Button();
            this.textBox_ExcelPath = new System.Windows.Forms.TextBox();
            this.label_ExcelPath = new System.Windows.Forms.Label();
            this.listView_DragExcel = new System.Windows.Forms.ListView();
            this.label_DragPrompt1 = new System.Windows.Forms.Label();
            this.label_DragPrompt2 = new System.Windows.Forms.Label();
            this.pictureBox_Excel = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_PitchRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_SpeechRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Volume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Excel)).BeginInit();
            this.SuspendLayout();
            // 
            // button_OpenFolder
            // 
            this.button_OpenFolder.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_OpenFolder.Location = new System.Drawing.Point(187, 458);
            this.button_OpenFolder.Name = "button_OpenFolder";
            this.button_OpenFolder.Size = new System.Drawing.Size(100, 28);
            this.button_OpenFolder.TabIndex = 3;
            this.button_OpenFolder.Text = "打开文件夹";
            this.button_OpenFolder.UseVisualStyleBackColor = true;
            this.button_OpenFolder.Click += new System.EventHandler(this.button_OpenFolder_Click);
            // 
            // button_Compose
            // 
            this.button_Compose.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_Compose.Location = new System.Drawing.Point(187, 414);
            this.button_Compose.Name = "button_Compose";
            this.button_Compose.Size = new System.Drawing.Size(100, 28);
            this.button_Compose.TabIndex = 2;
            this.button_Compose.Text = "合成";
            this.button_Compose.UseVisualStyleBackColor = true;
            this.button_Compose.Click += new System.EventHandler(this.button_Compose_Click);
            // 
            // comboBox_VoiceQuality
            // 
            this.comboBox_VoiceQuality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_VoiceQuality.FormattingEnabled = true;
            this.comboBox_VoiceQuality.Location = new System.Drawing.Point(153, 308);
            this.comboBox_VoiceQuality.Name = "comboBox_VoiceQuality";
            this.comboBox_VoiceQuality.Size = new System.Drawing.Size(174, 20);
            this.comboBox_VoiceQuality.TabIndex = 12;
            this.comboBox_VoiceQuality.SelectedIndexChanged += new System.EventHandler(this.comboBox_VoiceQuality_SelectedIndexChanged);
            // 
            // label_VoiceQuality
            // 
            this.label_VoiceQuality.AutoSize = true;
            this.label_VoiceQuality.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_VoiceQuality.Location = new System.Drawing.Point(68, 310);
            this.label_VoiceQuality.Name = "label_VoiceQuality";
            this.label_VoiceQuality.Size = new System.Drawing.Size(77, 14);
            this.label_VoiceQuality.TabIndex = 11;
            this.label_VoiceQuality.Text = "选择音色：";
            // 
            // label_PitchRateValue
            // 
            this.label_PitchRateValue.AutoSize = true;
            this.label_PitchRateValue.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_PitchRateValue.Location = new System.Drawing.Point(114, 224);
            this.label_PitchRateValue.Name = "label_PitchRateValue";
            this.label_PitchRateValue.Size = new System.Drawing.Size(0, 16);
            this.label_PitchRateValue.TabIndex = 31;
            // 
            // trackBar_PitchRate
            // 
            this.trackBar_PitchRate.Location = new System.Drawing.Point(59, 242);
            this.trackBar_PitchRate.Maximum = 500;
            this.trackBar_PitchRate.Minimum = -500;
            this.trackBar_PitchRate.Name = "trackBar_PitchRate";
            this.trackBar_PitchRate.Size = new System.Drawing.Size(104, 45);
            this.trackBar_PitchRate.TabIndex = 30;
            this.trackBar_PitchRate.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar_PitchRate.Value = -500;
            this.trackBar_PitchRate.Scroll += new System.EventHandler(this.trackBar_PitchRate_Scroll);
            // 
            // label_PitchRate
            // 
            this.label_PitchRate.AutoSize = true;
            this.label_PitchRate.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_PitchRate.Location = new System.Drawing.Point(67, 225);
            this.label_PitchRate.Name = "label_PitchRate";
            this.label_PitchRate.Size = new System.Drawing.Size(49, 14);
            this.label_PitchRate.TabIndex = 29;
            this.label_PitchRate.Text = "语调：";
            // 
            // label_SpeechRateValue
            // 
            this.label_SpeechRateValue.AutoSize = true;
            this.label_SpeechRateValue.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_SpeechRateValue.Location = new System.Drawing.Point(114, 149);
            this.label_SpeechRateValue.Name = "label_SpeechRateValue";
            this.label_SpeechRateValue.Size = new System.Drawing.Size(0, 16);
            this.label_SpeechRateValue.TabIndex = 28;
            // 
            // trackBar_SpeechRate
            // 
            this.trackBar_SpeechRate.Location = new System.Drawing.Point(59, 167);
            this.trackBar_SpeechRate.Maximum = 500;
            this.trackBar_SpeechRate.Minimum = -500;
            this.trackBar_SpeechRate.Name = "trackBar_SpeechRate";
            this.trackBar_SpeechRate.Size = new System.Drawing.Size(104, 45);
            this.trackBar_SpeechRate.TabIndex = 27;
            this.trackBar_SpeechRate.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar_SpeechRate.Value = -500;
            this.trackBar_SpeechRate.Scroll += new System.EventHandler(this.trackBar_SpeechRate_Scroll);
            // 
            // label_SpeechRate
            // 
            this.label_SpeechRate.AutoSize = true;
            this.label_SpeechRate.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_SpeechRate.Location = new System.Drawing.Point(67, 150);
            this.label_SpeechRate.Name = "label_SpeechRate";
            this.label_SpeechRate.Size = new System.Drawing.Size(49, 14);
            this.label_SpeechRate.TabIndex = 26;
            this.label_SpeechRate.Text = "语速：";
            // 
            // label_VolumeValue
            // 
            this.label_VolumeValue.AutoSize = true;
            this.label_VolumeValue.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_VolumeValue.Location = new System.Drawing.Point(114, 75);
            this.label_VolumeValue.Name = "label_VolumeValue";
            this.label_VolumeValue.Size = new System.Drawing.Size(0, 16);
            this.label_VolumeValue.TabIndex = 25;
            // 
            // trackBar_Volume
            // 
            this.trackBar_Volume.Location = new System.Drawing.Point(59, 93);
            this.trackBar_Volume.Maximum = 100;
            this.trackBar_Volume.Name = "trackBar_Volume";
            this.trackBar_Volume.Size = new System.Drawing.Size(104, 45);
            this.trackBar_Volume.TabIndex = 24;
            this.trackBar_Volume.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar_Volume.Scroll += new System.EventHandler(this.trackBar_Volume_Scroll);
            // 
            // label_Volume
            // 
            this.label_Volume.AutoSize = true;
            this.label_Volume.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Volume.Location = new System.Drawing.Point(67, 76);
            this.label_Volume.Name = "label_Volume";
            this.label_Volume.Size = new System.Drawing.Size(49, 14);
            this.label_Volume.TabIndex = 23;
            this.label_Volume.Text = "音量：";
            // 
            // button_SetPath
            // 
            this.button_SetPath.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_SetPath.Location = new System.Drawing.Point(367, 355);
            this.button_SetPath.Name = "button_SetPath";
            this.button_SetPath.Size = new System.Drawing.Size(60, 30);
            this.button_SetPath.TabIndex = 22;
            this.button_SetPath.Text = "浏览";
            this.button_SetPath.UseVisualStyleBackColor = true;
            this.button_SetPath.Click += new System.EventHandler(this.button_SetPath_Click);
            // 
            // textBox_AudioPath
            // 
            this.textBox_AudioPath.Location = new System.Drawing.Point(153, 359);
            this.textBox_AudioPath.Name = "textBox_AudioPath";
            this.textBox_AudioPath.Size = new System.Drawing.Size(197, 21);
            this.textBox_AudioPath.TabIndex = 21;
            // 
            // label_AudioPath
            // 
            this.label_AudioPath.AutoSize = true;
            this.label_AudioPath.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_AudioPath.Location = new System.Drawing.Point(40, 361);
            this.label_AudioPath.Name = "label_AudioPath";
            this.label_AudioPath.Size = new System.Drawing.Size(105, 14);
            this.label_AudioPath.TabIndex = 20;
            this.label_AudioPath.Text = "语音文件路径：";
            // 
            // button_SelectExcel
            // 
            this.button_SelectExcel.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_SelectExcel.Location = new System.Drawing.Point(378, 23);
            this.button_SelectExcel.Name = "button_SelectExcel";
            this.button_SelectExcel.Size = new System.Drawing.Size(60, 30);
            this.button_SelectExcel.TabIndex = 34;
            this.button_SelectExcel.Text = "选择";
            this.button_SelectExcel.UseVisualStyleBackColor = true;
            this.button_SelectExcel.Click += new System.EventHandler(this.button_SelectExcel_Click);
            // 
            // textBox_ExcelPath
            // 
            this.textBox_ExcelPath.Location = new System.Drawing.Point(164, 27);
            this.textBox_ExcelPath.Name = "textBox_ExcelPath";
            this.textBox_ExcelPath.ReadOnly = true;
            this.textBox_ExcelPath.Size = new System.Drawing.Size(197, 21);
            this.textBox_ExcelPath.TabIndex = 33;
            // 
            // label_ExcelPath
            // 
            this.label_ExcelPath.AutoSize = true;
            this.label_ExcelPath.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_ExcelPath.Location = new System.Drawing.Point(51, 29);
            this.label_ExcelPath.Name = "label_ExcelPath";
            this.label_ExcelPath.Size = new System.Drawing.Size(112, 14);
            this.label_ExcelPath.TabIndex = 32;
            this.label_ExcelPath.Text = "Excel表格路径：";
            // 
            // listView_DragExcel
            // 
            this.listView_DragExcel.AllowDrop = true;
            this.listView_DragExcel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.listView_DragExcel.HideSelection = false;
            this.listView_DragExcel.Location = new System.Drawing.Point(227, 75);
            this.listView_DragExcel.Name = "listView_DragExcel";
            this.listView_DragExcel.Size = new System.Drawing.Size(200, 200);
            this.listView_DragExcel.TabIndex = 38;
            this.listView_DragExcel.UseCompatibleStateImageBehavior = false;
            this.listView_DragExcel.DragDrop += new System.Windows.Forms.DragEventHandler(this.listView_DragExcel_DragDrop);
            this.listView_DragExcel.DragEnter += new System.Windows.Forms.DragEventHandler(this.listView_DragExcel_DragEnter);
            // 
            // label_DragPrompt1
            // 
            this.label_DragPrompt1.AutoSize = true;
            this.label_DragPrompt1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label_DragPrompt1.CausesValidation = false;
            this.label_DragPrompt1.Enabled = false;
            this.label_DragPrompt1.Font = new System.Drawing.Font("宋体", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_DragPrompt1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_DragPrompt1.Location = new System.Drawing.Point(268, 122);
            this.label_DragPrompt1.Name = "label_DragPrompt1";
            this.label_DragPrompt1.Size = new System.Drawing.Size(114, 47);
            this.label_DragPrompt1.TabIndex = 39;
            this.label_DragPrompt1.Text = "拖拽";
            // 
            // label_DragPrompt2
            // 
            this.label_DragPrompt2.AutoSize = true;
            this.label_DragPrompt2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label_DragPrompt2.CausesValidation = false;
            this.label_DragPrompt2.Enabled = false;
            this.label_DragPrompt2.Font = new System.Drawing.Font("宋体", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_DragPrompt2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_DragPrompt2.Location = new System.Drawing.Point(260, 180);
            this.label_DragPrompt2.Name = "label_DragPrompt2";
            this.label_DragPrompt2.Size = new System.Drawing.Size(140, 47);
            this.label_DragPrompt2.TabIndex = 40;
            this.label_DragPrompt2.Text = "Excel";
            // 
            // pictureBox_Excel
            // 
            this.pictureBox_Excel.Enabled = false;
            this.pictureBox_Excel.ErrorImage = null;
            this.pictureBox_Excel.Image = global::CSharp_AliyunTTS_Batch.Properties.Resources.ExcelLogo;
            this.pictureBox_Excel.InitialImage = null;
            this.pictureBox_Excel.Location = new System.Drawing.Point(237, 85);
            this.pictureBox_Excel.Name = "pictureBox_Excel";
            this.pictureBox_Excel.Size = new System.Drawing.Size(180, 180);
            this.pictureBox_Excel.TabIndex = 42;
            this.pictureBox_Excel.TabStop = false;
            this.pictureBox_Excel.Visible = false;
            // 
            // Form_TTS_Batch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(484, 501);
            this.Controls.Add(this.pictureBox_Excel);
            this.Controls.Add(this.label_DragPrompt2);
            this.Controls.Add(this.label_DragPrompt1);
            this.Controls.Add(this.listView_DragExcel);
            this.Controls.Add(this.button_SelectExcel);
            this.Controls.Add(this.textBox_ExcelPath);
            this.Controls.Add(this.label_ExcelPath);
            this.Controls.Add(this.label_PitchRateValue);
            this.Controls.Add(this.trackBar_PitchRate);
            this.Controls.Add(this.label_PitchRate);
            this.Controls.Add(this.label_SpeechRateValue);
            this.Controls.Add(this.trackBar_SpeechRate);
            this.Controls.Add(this.label_SpeechRate);
            this.Controls.Add(this.label_VolumeValue);
            this.Controls.Add(this.trackBar_Volume);
            this.Controls.Add(this.label_Volume);
            this.Controls.Add(this.button_SetPath);
            this.Controls.Add(this.textBox_AudioPath);
            this.Controls.Add(this.label_AudioPath);
            this.Controls.Add(this.comboBox_VoiceQuality);
            this.Controls.Add(this.label_VoiceQuality);
            this.Controls.Add(this.button_OpenFolder);
            this.Controls.Add(this.button_Compose);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_TTS_Batch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "阿里云批量语音合成器";
            this.Load += new System.EventHandler(this.Form_TTS_Batch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_PitchRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_SpeechRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Volume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Excel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_OpenFolder;
        private System.Windows.Forms.Button button_Compose;
        private System.Windows.Forms.ComboBox comboBox_VoiceQuality;
        private System.Windows.Forms.Label label_VoiceQuality;
        private System.Windows.Forms.Label label_PitchRateValue;
        private System.Windows.Forms.TrackBar trackBar_PitchRate;
        private System.Windows.Forms.Label label_PitchRate;
        private System.Windows.Forms.Label label_SpeechRateValue;
        private System.Windows.Forms.TrackBar trackBar_SpeechRate;
        private System.Windows.Forms.Label label_SpeechRate;
        private System.Windows.Forms.Label label_VolumeValue;
        private System.Windows.Forms.TrackBar trackBar_Volume;
        private System.Windows.Forms.Label label_Volume;
        private System.Windows.Forms.Button button_SetPath;
        private System.Windows.Forms.TextBox textBox_AudioPath;
        private System.Windows.Forms.Label label_AudioPath;
        private System.Windows.Forms.Button button_SelectExcel;
        private System.Windows.Forms.TextBox textBox_ExcelPath;
        private System.Windows.Forms.Label label_ExcelPath;
        private System.Windows.Forms.ListView listView_DragExcel;
        private System.Windows.Forms.Label label_DragPrompt1;
        private System.Windows.Forms.Label label_DragPrompt2;
        private System.Windows.Forms.PictureBox pictureBox_Excel;
    }
}

