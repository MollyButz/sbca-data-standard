using SBCA_DataStandard.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBCA_DataStandard.Materials
{
    public class Screw : Material
    {
        public override MaterialType MaterialType => MaterialType.Screw;

        public double ShankDiameter { get; set; }

        public double HeadDiameter { get; set; }

        public double Length { get; set; }
    }
}
