namespace ChippyController
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.ScreenSizeLabel = new System.Windows.Forms.Label();
            this.KeyName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ScreenSizeLabel
            // 
            this.ScreenSizeLabel.AutoSize = true;
            this.ScreenSizeLabel.Location = new System.Drawing.Point(12, 9);
            this.ScreenSizeLabel.Name = "ScreenSizeLabel";
            this.ScreenSizeLabel.Size = new System.Drawing.Size(99, 18);
            this.ScreenSizeLabel.TabIndex = 0;
            this.ScreenSizeLabel.Text = "0000X0000";
            this.ScreenSizeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // KeyName
            // 
            this.KeyName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.KeyName.AutoSize = true;
            this.KeyName.Location = new System.Drawing.Point(117, 9);
            this.KeyName.Name = "KeyName";
            this.KeyName.Size = new System.Drawing.Size(86, 18);
            this.KeyName.TabIndex = 1;
            this.KeyName.Text = "KeyName";
            this.KeyName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(275, 37);
            this.Controls.Add(this.KeyName);
            this.Controls.Add(this.ScreenSizeLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.Text = "Chippy Controller";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ScreenSizeLabel;
        private System.Windows.Forms.Label KeyName;
    }
}

