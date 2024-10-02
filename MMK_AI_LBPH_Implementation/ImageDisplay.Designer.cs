namespace MMK_AI_LBPH_Implementation
{
    partial class ImageDisplay
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
            groupBoxImageProperties = new GroupBox();
            textBoxImageLabel = new TextBox();
            labelImageLabel = new Label();
            textBoxImageName = new TextBox();
            labelImageName = new Label();
            groupBoxImage = new GroupBox();
            labelImageProperties = new Label();
            labelHelpDisplay = new Label();
            pictureBoxImage = new PictureBox();
            buttonOK = new Button();
            buttonCancel = new Button();
            groupBoxImageProperties.SuspendLayout();
            groupBoxImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxImage).BeginInit();
            SuspendLayout();
            // 
            // groupBoxImageProperties
            // 
            groupBoxImageProperties.Controls.Add(textBoxImageLabel);
            groupBoxImageProperties.Controls.Add(labelImageLabel);
            groupBoxImageProperties.Controls.Add(textBoxImageName);
            groupBoxImageProperties.Controls.Add(labelImageName);
            groupBoxImageProperties.Location = new Point(12, 12);
            groupBoxImageProperties.Name = "groupBoxImageProperties";
            groupBoxImageProperties.Size = new Size(336, 179);
            groupBoxImageProperties.TabIndex = 0;
            groupBoxImageProperties.TabStop = false;
            groupBoxImageProperties.Text = "مشخصات تصویر";
            // 
            // textBoxImageLabel
            // 
            textBoxImageLabel.Location = new Point(6, 121);
            textBoxImageLabel.Name = "textBoxImageLabel";
            textBoxImageLabel.Size = new Size(324, 27);
            textBoxImageLabel.TabIndex = 3;
            textBoxImageLabel.TextAlign = HorizontalAlignment.Center;
            // 
            // labelImageLabel
            // 
            labelImageLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelImageLabel.ForeColor = Color.Blue;
            labelImageLabel.Location = new Point(0, 93);
            labelImageLabel.Name = "labelImageLabel";
            labelImageLabel.Size = new Size(330, 25);
            labelImageLabel.TabIndex = 2;
            labelImageLabel.Text = "برچسب:";
            labelImageLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBoxImageName
            // 
            textBoxImageName.Location = new Point(6, 55);
            textBoxImageName.Name = "textBoxImageName";
            textBoxImageName.Size = new Size(324, 27);
            textBoxImageName.TabIndex = 1;
            textBoxImageName.TextAlign = HorizontalAlignment.Center;
            // 
            // labelImageName
            // 
            labelImageName.Location = new Point(6, 27);
            labelImageName.Name = "labelImageName";
            labelImageName.Size = new Size(330, 25);
            labelImageName.TabIndex = 0;
            labelImageName.Text = "نام تصویر:";
            labelImageName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // groupBoxImage
            // 
            groupBoxImage.Controls.Add(labelImageProperties);
            groupBoxImage.Controls.Add(labelHelpDisplay);
            groupBoxImage.Controls.Add(pictureBoxImage);
            groupBoxImage.Location = new Point(354, 12);
            groupBoxImage.Name = "groupBoxImage";
            groupBoxImage.Size = new Size(242, 179);
            groupBoxImage.TabIndex = 1;
            groupBoxImage.TabStop = false;
            groupBoxImage.Text = "تصویر";
            // 
            // labelImageProperties
            // 
            labelImageProperties.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelImageProperties.ForeColor = SystemColors.GrayText;
            labelImageProperties.Location = new Point(112, 23);
            labelImageProperties.Name = "labelImageProperties";
            labelImageProperties.Size = new Size(124, 94);
            labelImageProperties.TabIndex = 2;
            labelImageProperties.Text = "طول:\r\n0\r\nعرض:\r\n0";
            labelImageProperties.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelHelpDisplay
            // 
            labelHelpDisplay.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelHelpDisplay.Location = new Point(6, 121);
            labelHelpDisplay.Name = "labelHelpDisplay";
            labelHelpDisplay.Size = new Size(230, 55);
            labelHelpDisplay.TabIndex = 1;
            labelHelpDisplay.Text = "(جهت نمایش ابعاد واقعی عکس،\r\nروی آن کلیک کنید)";
            labelHelpDisplay.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBoxImage
            // 
            pictureBoxImage.Cursor = Cursors.Hand;
            pictureBoxImage.Location = new Point(6, 16);
            pictureBoxImage.Name = "pictureBoxImage";
            pictureBoxImage.Size = new Size(100, 100);
            pictureBoxImage.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxImage.TabIndex = 0;
            pictureBoxImage.TabStop = false;
            pictureBoxImage.Click += pictureBoxImage_Click;
            // 
            // buttonOK
            // 
            buttonOK.Cursor = Cursors.Hand;
            buttonOK.DialogResult = DialogResult.OK;
            buttonOK.ForeColor = Color.DarkGreen;
            buttonOK.Location = new Point(502, 209);
            buttonOK.Name = "buttonOK";
            buttonOK.Size = new Size(94, 29);
            buttonOK.TabIndex = 2;
            buttonOK.Text = "تأیید";
            buttonOK.UseVisualStyleBackColor = true;
            buttonOK.Click += buttonOK_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Cursor = Cursors.Hand;
            buttonCancel.DialogResult = DialogResult.Cancel;
            buttonCancel.ForeColor = Color.Red;
            buttonCancel.Location = new Point(402, 209);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(94, 29);
            buttonCancel.TabIndex = 3;
            buttonCancel.Text = "لغو";
            buttonCancel.UseVisualStyleBackColor = true;
            // 
            // ImageDisplay
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(608, 250);
            Controls.Add(buttonCancel);
            Controls.Add(buttonOK);
            Controls.Add(groupBoxImage);
            Controls.Add(groupBoxImageProperties);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ImageDisplay";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "مشخصات تصویر انتخابی";
            groupBoxImageProperties.ResumeLayout(false);
            groupBoxImageProperties.PerformLayout();
            groupBoxImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxImage).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxImageProperties;
        private TextBox textBoxImageName;
        private Label labelImageName;
        private TextBox textBoxImageLabel;
        private Label labelImageLabel;
        private GroupBox groupBoxImage;
        private Label labelHelpDisplay;
        private PictureBox pictureBoxImage;
        private Label labelImageProperties;
        private Button buttonOK;
        private Button buttonCancel;
    }
}