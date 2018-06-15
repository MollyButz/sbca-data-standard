using SBCA_DataStandard.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBCA_DataStandard
{
    public class MetalPlate
    {
        public Guid Guid { get; set; }

        public string PlateType { get; set; }

        public string PlateManufacturer { get; set; }

        public double Width { get; set; }

        public double Length { get; set; }

        public double Thickness { get; set; }

        public PlateGauge PlateGauge { get; set; }
    }
}
