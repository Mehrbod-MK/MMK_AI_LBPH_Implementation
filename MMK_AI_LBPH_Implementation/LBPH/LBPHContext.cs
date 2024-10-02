using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMK_AI_LBPH_Implementation.LBPH
{
    public class LBPHContext
    {
        private List<LBPHImage> images = new List<LBPHImage>();
        private List<List<double>> histograms = new List<List<double>>();
        private uint neighbours = 1;


        public List<LBPHImage> Images => images;
        public List<List<double>> Histograms => histograms;
        public uint Neighbours { get => neighbours; set => neighbours = value; }

    }
}
