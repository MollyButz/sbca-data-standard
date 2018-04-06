using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBCA_DataStandard
{
    public class Bearing
    {
        public string Name { get; set; }

        public double Width { get; set; }

        public double Depth { get; set; }

        public double BearingArea { get; set; }

        public double CenterPointX { get; set; }

        public long CenterPointY { get; set; }

        public string Anchor { get; set; }

        public string BearingType { get; set; }
    }
}
