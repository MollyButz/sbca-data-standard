using SBCA_DataStandard.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBCA_DataStandard.Materials
{
    public class ConnectorPlate : Material
    {
        public override MaterialType MaterialType => MaterialType.ConnectorPlate;

        public string PlateType { get; set; }

        public PlateManufacturer PlateManufacturer { get; set; }

        public double Width { get; set; }

        public double Length { get; set; }

        public double Thickness { get; set; }

        public PlateGauge PlateGauge { get; set; }

        public StrengthGrade StrengthGrade { get; set; }

        public bool Galvinized { get; set; }
    }
}
