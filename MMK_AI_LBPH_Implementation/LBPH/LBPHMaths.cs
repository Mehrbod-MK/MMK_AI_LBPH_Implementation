using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMK_AI_LBPH_Implementation.LBPH
{
    internal class LBPHMaths
    {
        private static void CheckHistograms(List<double>? hist1, List<double>? hist2)
        {
            if (hist1 == null || hist2 == null)
            {
                throw new ArgumentNullException("hist1 | hist2", "هیستوگرام‌ها نمی‌توانند null باشند.");
            }
            if(hist1.Count == 0 || hist2.Count == 0)
            {
                throw new ArgumentOutOfRangeException("hist1 | hist2", "هیستوگرام‌ها نمی‌توانند خالی باشند.");
            }
            if(hist1.Count != hist2.Count)
            {
                throw new ArgumentException("hist1 != hist2", "طول هیستوگرام‌ها باید با یکدیگر برابر باشد.");
            }
        }

        public static double HistogramDiffs_ChiSquare(
            List<double>? hist1, List<double>? hist2
            )
        {
            CheckHistograms(hist1, hist2);

            double sum = 0.0f;

            for(int index = 0; index < hist1.Count; index++)
            {
                double numerator = Math.Pow(hist1[index] - hist2[index], 2.0);
                double denominator = hist1[index] == 0 ? numerator : hist1[index];
                sum += numerator / denominator;
            }

            return sum;
        }

        public static double HistogramDiffs_AbsoluteDifference(
            List<double>? hist1, List<double>? hist2
            )
        {
            CheckHistograms(hist1, hist2);

            double sum = 0.0f;

            for (int index = 0; index < hist1.Count; index++)
            {
                sum += Math.Abs(hist1[index] - hist2[index]);
            }

            return sum;
        }

        public static double HistogramDiffs_EuclideanDistance(
            List<double>? hist1, List<double>? hist2
            )
        {
            CheckHistograms(hist1, hist2);

            double sum = 0.0f;

            for (int index = 0; index < hist1.Count; index++)
            {
                sum += Math.Pow(hist1[index] - hist2[index], 2.0);
            }

            return sum;
        }

        public static double HistogramDiffs_NormalizedEuclideanDistance(
            List<double>? hist1, List<double>? hist2
            )
        {
            CheckHistograms(hist1, hist2);

            double sum = 0.0f;

            for (int index = 0; index < hist1.Count; index++)
            {
                sum += Math.Pow(hist1[index] - hist2[index], 2.0) / hist1.Count;
            }

            return sum;
        }
    }
}
