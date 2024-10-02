using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMK_AI_LBPH_Implementation.LBPH
{
    public class LBPHImage
    {
        private string imageName = string.Empty;
        private string label = string.Empty;
        private Bitmap? imageObject = null;

        public string ImageName { get => imageName; set => imageName = value; }
        public string Label { get => label; set => label = value; }
        public Bitmap? ImageObject => imageObject;

        public void LoadGrayscale(Bitmap inputImage)
        {
            for(int i = 0; i < inputImage.Height; i++)
            {
                for(int j = 0; j < inputImage.Width; j++)
                {
                    var pixel = inputImage.GetPixel(i, j);
                    var grayScaledPixelColorValue =
                        (int)Math.Floor(0.3 * pixel.R) +
                        (int)Math.Floor(0.59 * pixel.G) +
                        (int)Math.Floor(0.11 * pixel.B);

                    pixel = Color.FromArgb(
                        pixel.A,
                        grayScaledPixelColorValue,
                        grayScaledPixelColorValue,
                        grayScaledPixelColorValue
                        );

                    inputImage.SetPixel(i, j, pixel);
                }
            }

            imageObject = new Bitmap(inputImage);
        }
    }
}
