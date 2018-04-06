using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBCA_DataStandard
{
    public class PlatePair
    {
        public double Angle { get; set; }

        public double[] Plate1TransformationMatrix { get; set; }

        public double[] Plate2TransformationMatrix { get; set; }

        public string Name { get; set; }

        public Geometry Plate1Geometry { get; set; }

        public Geometry Plate2Geometry { get; set; }

        public double CenterX { get; set; }

        public double CenterY { get; set; }

        public double CenterZ { get; set; }

        public string PlatePlacement { get; set; }

        public string PlateType { get; set; }

        public string PlateManufacturer { get; set; }

        public double Width { get; set; }

        public double Length { get; set; }

        public double Thickness { get; set; }

        public double BaseThickness { get; set; }
    }
}
