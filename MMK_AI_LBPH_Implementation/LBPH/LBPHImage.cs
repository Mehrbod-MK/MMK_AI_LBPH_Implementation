using System;
using System.Collections.Generic;
using System.Diagnostics;
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
        private List<float[]>? histograms = null;

        private List<List<long>>? patternedBitmap = null;

        public string ImageName { get => imageName; set => imageName = value; }
        public string Label { get => label; set => label = value; }
        public Bitmap? ImageObject => imageObject;
        public List<float[]>? Histograms => histograms;

        public enum DistanceCalculationModes
        {
            ChiSquare,
            EuclideanDistance,
            NormalizedEuclideanDistance,
            AbsoluteValue,
        }

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

        private static char GetThresholdBooleanChar(int value, int threshold)
        {
            if (value >= threshold)
                return '1';
            else
                return '0';
        }

        public static List<float[]>? GetBitmapHistogram(LBPHContext context, Bitmap bitmap)
        {
            LBPHImage image = new LBPHImage() { imageObject = bitmap };
            image.Train(context.Radius, context.GridX, context.GridY);
            return image.Histograms;
        }

        public void Train(int radius, int gridX, int gridY)
        {
            if (radius <= 0)
                throw new ArgumentOutOfRangeException(message: "مقدار همسایگی درایه ماتریس نمی‌تواند صفر باشد.", null);

            if (imageObject == null)
                throw new NullReferenceException("عکس در فرمت سیاه‌سفید بارگیری نشده است.");

            // Resize bitmap.
            Bitmap resizedBitmap = new Bitmap(imageObject, 32, 32);

            // Calculate local binary patterns.
            patternedBitmap = new List<List<long>>();
            for(int i = 0; i < resizedBitmap.Height; i++)
            {
                List<long> patternedRow = new List<long>();

                for(int j = 0; j < resizedBitmap.Width; j++)
                {
                    // Local Binary Pattern string.
                    StringBuilder binaryPattern = new StringBuilder();

                    // Neighbouring offsets.
                    for(int neighbourY = i - radius; neighbourY < i + radius; neighbourY++)
                    {
                        for(int neighbourX = j - radius; neighbourX < j + radius; neighbourX++)
                        {
                            // Out-of-bounds X neighbour.
                            if(neighbourX < 0 || neighbourX >= resizedBitmap.Width || neighbourY < 0 || neighbourY >= resizedBitmap.Height)
                            {
                                binaryPattern.Append('0');
                            }
                            else
                            {
                                binaryPattern.Append(GetThresholdBooleanChar(resizedBitmap.GetPixel(neighbourX, neighbourY).R, imageObject.GetPixel(i, j).R));
                            }
                        }
                    }

                    // Add binary representation to row.
                    patternedRow.Add(Convert.ToInt64(binaryPattern.ToString(), 2));
                }

                // Add patterned row to collection.
                patternedBitmap.Add(patternedRow);
            }

            // Calculate histograms.
            int numCells = (2 * radius + 1) * (2 * radius + 1) - 1;
            histograms = new List<float[]>();

            int rows = patternedBitmap.Count;
            int columns = patternedBitmap[0].Count;

            if (gridX < 0 || gridX >= columns)
                throw new ArgumentOutOfRangeException("gridX", "طول مربع برشی از ابعاد تصویر تجاوز می‌کند.");
            if (gridY < 0 || gridY >= rows)
                throw new ArgumentOutOfRangeException("gridY", "طول مربع برشی از ابعاد تصویر تجاوز می‌کند.");

            int gridWidth = columns / gridX;
            int gridHeight = rows / gridY;

            for(int gY = 0; gY < gridY; gY++)
            {
                for (int gX = 0; gX < gridX; gX++)
                {
                    float[] regionHistogram = new float[(long)Math.Pow(2, numCells)];

                    int startPosX = gX * gridWidth;
                    int startPosY = gY * gridHeight;
                    int endPosX = (gX + 1) * gridWidth;
                    int endPosY = (gY + 1) * gridHeight;

                    if (gX == gridX - 1)
                    {
                        endPosX = columns;

                    }
                    if (gY == gridY - 1)
                    {
                        endPosY = rows;
                    }

                    for (int y = startPosY; y < endPosY; y++) 
                    {
                        for (int x = startPosX; x < endPosX; x++) 
                        {
                            // Make sure we are trying to access a valid position
                            if (x < rows) 
                            {
                                if (y < columns) 
                                {
                                    regionHistogram[patternedBitmap[x][y]] += 1;
                                }
                            }
                        }
                    }

                    // Add to current histograms.
                    histograms.Add(regionHistogram);
                }
            }

            resizedBitmap.Dispose();
        }
    }
}
