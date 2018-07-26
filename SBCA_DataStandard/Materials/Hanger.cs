using SBCA_DataStandard.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SBCA_DataStandard.Enums.HangerEnums;

namespace SBCA_DataStandard.Materials
{
    public class Hanger : Material
    {
        public override MaterialType MaterialType => MaterialType.Hanger;

        public string Description { get; set; }

        public Geometry Geometry { get; set; }

        public HangerManufacturer HangerManufacturer { get; set; }
    }
}
