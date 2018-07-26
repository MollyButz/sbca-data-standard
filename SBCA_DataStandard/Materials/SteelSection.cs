using SBCA_DataStandard.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBCA_DataStandard.Materials
{
    public class SteelSection : Material
    {
        public override MaterialType MaterialType => MaterialType.SteelSection;
        public double Width { get; set; }
        public double Thickness { get; set; }
        public Gauge Gauge { get; set; }
        public SteelSectionShape SteelSectionShape { get; set; }
    }
}
