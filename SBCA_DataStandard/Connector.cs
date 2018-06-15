using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SBCA_DataStandard.Enums;


namespace SBCA_DataStandard
{
    public class Connector
    { 
        public string Name { get; set; }

        public string MaterialDescription { get; set; }

        public MaterialType MaterialType { get; set; }

        public Guid MaterialGuid { get; set; }

        public double[] Center { get; set; }

        public double[] NormalDirection { get; set; }

        /// <summary>
        /// Clockwise angle from the X Axis
        /// </summary>
        public double Angle { get; set; }

    }
}
