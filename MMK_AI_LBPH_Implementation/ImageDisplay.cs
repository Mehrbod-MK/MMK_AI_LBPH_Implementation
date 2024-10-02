using MMK_AI_LBPH_Implementation.LBPH;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MMK_AI_LBPH_Implementation
{
    public partial class ImageDisplay : Form
    {
        private readonly LBPHImage lbphImage;

        private ImageDisplay(LBPHImage lbphImage)
        {
            InitializeComponent();

            this.lbphImage = lbphImage;
            pictureBoxImage.Image = lbphImage.ImageObject;
            textBoxImageName.Text = lbphImage.ImageName;
            textBoxImageLabel.Text = lbphImage.Label;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (Helpers.IsBlankString(textBoxImageLabel.Text))
            {
                Helpers.ShowWarningMessageBox("هشدار", "مقدار برچسب تصویر نمی‌تواند خالی باشد.");
                DialogResult = DialogResult.None;
                return;
            }

            lbphImage.ImageName = textBoxImageName.Text;
            lbphImage.Label = textBoxImageLabel.Text;
        }

        public static LBPHImage? EditLBPHImageProperties(LBPHImage lbphImage)
        {
            ImageDisplay imageDisplay = new ImageDisplay(lbphImage);

            if (imageDisplay.ShowDialog() == DialogResult.OK)
                return imageDisplay.lbphImage;

            return null;
        }

        private void pictureBoxImage_Click(object sender, EventArgs e)
        {
            if(lbphImage.ImageObject != null)
                Helpers.ShowImageFullDisplay(lbphImage.ImageObject);
        }
    }
}
