namespace MMK_AI_LBPH_Implementation
{
    partial class LoadingForm
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
            labelStatus = new Label();
            progressBarProgress = new ProgressBar();
            SuspendLayout();
            // 
            // labelStatus
            // 
            labelStatus.AutoEllipsis = true;
            labelStatus.Location = new Point(12, 9);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(476, 49);
            labelStatus.TabIndex = 0;
            labelStatus.Text = "در حال بارگیری...";
            labelStatus.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // progressBarProgress
            // 
            progressBarProgress.Location = new Point(12, 61);
            progressBarProgress.Name = "progressBarProgress";
            progressBarProgress.Size = new Size(476, 31);
            progressBarProgress.TabIndex = 1;
            // 
            // LoadingForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 104);
            Controls.Add(progressBarProgress);
            Controls.Add(labelStatus);
            Cursor = Cursors.WaitCursor;
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LoadingForm";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "در حال انجام کار...";
            FormClosing += LoadingForm_FormClosing;
            ResumeLayout(false);
        }

        #endregion

        public Label labelStatus;
        public ProgressBar progressBarProgress;
    }
}