
namespace CSharp_AliyunTTS_Batch
{
    partial class Form_ProgressBar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_Title = new System.Windows.Forms.Label();
            this.progressBar_TTS = new System.Windows.Forms.ProgressBar();
            this.label_Progress = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_Title
            // 
            this.label_Title.AutoSize = true;
            this.label_Title.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Title.Location = new System.Drawing.Point(100, 39);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(189, 20);
            this.label_Title.TabIndex = 0;
            this.label_Title.Text = "Excel语音合成中...";
            // 
            // progressBar_TTS
            // 
            this.progressBar_TTS.Location = new System.Drawing.Point(71, 93);
            this.progressBar_TTS.Maximum = 2;
            this.progressBar_TTS.Name = "progressBar_TTS";
            this.progressBar_TTS.Size = new System.Drawing.Size(240, 23);
            this.progressBar_TTS.Step = 1;
            this.progressBar_TTS.TabIndex = 1;
            this.progressBar_TTS.Value = 1;
            // 
            // label_Progress
            // 
            this.label_Progress.AutoSize = true;
            this.label_Progress.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Progress.Location = new System.Drawing.Point(146, 145);
            this.label_Progress.Name = "label_Progress";
            this.label_Progress.Size = new System.Drawing.Size(68, 27);
            this.label_Progress.TabIndex = 2;
            this.label_Progress.Text = "5/10";
            // 
            // Form_ProgressBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 201);
            this.ControlBox = false;
            this.Controls.Add(this.label_Progress);
            this.Controls.Add(this.progressBar_TTS);
            this.Controls.Add(this.label_Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_ProgressBar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "语音合成进度";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_Prompt_Closed);
            this.Load += new System.EventHandler(this.Form_Prompt_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.ProgressBar progressBar_TTS;
        private System.Windows.Forms.Label label_Progress;
    }
}