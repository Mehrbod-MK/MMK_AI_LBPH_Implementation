using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMK_AI_LBPH_Implementation.LBPH
{
    public class LBPHContext
    {
        private List<LBPHImage> trainImages = new List<LBPHImage>();
        private List<Bitmap> testImages = new List<Bitmap>();
        private int radius = 1, gridX = 8, gridY = 8;

        public List<LBPHImage> TrainImages => trainImages;
        public List<Bitmap> TestImages => testImages;
        public int Radius { get => radius; set => radius = value; }
        public int GridX { get => gridX; set => gridX = value; }
        public int GridY { get => gridY; set => gridY = value; }

        public string Predict(Bitmap bitmap)
        {
            var inputHistogram = LBPHImage.GetBitmapHistogram(this, bitmap);

            // Calculate first minimum distance.
            double minDistance = LBPHMaths.HistogramDiffs_AbsoluteDifference(inputHistogram, trainImages[0].Histograms);
            string minLabel = trainImages[0].Label;
            
            // Find the correct minimum distance.
            for(int i = 1; i < trainImages.Count; i++)
            {
                var distance = LBPHMaths.HistogramDiffs_AbsoluteDifference(inputHistogram, trainImages[i].Histograms);

                if((double.IsNaN(minDistance)) || (distance < minDistance))
                {
                    minDistance = distance;
                    minLabel = trainImages[i].Label;
                }
            }

            return minLabel;
        }
    }
}
