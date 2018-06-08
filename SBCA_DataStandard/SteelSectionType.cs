using SBCA_DataStandard.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBCA_DataStandard
{
    public class SteelSection
    {
        public Guid Guid { get; set; }
        public double Width { get; set; }
        public double Thickness { get; set; }
        public Gauge Gauge { get; set; }
        public SteelSectionShape SteelSectionShape { get; set; }
    }
}
