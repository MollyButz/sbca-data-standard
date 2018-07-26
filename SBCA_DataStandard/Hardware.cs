using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SBCA_DataStandard.Enums;


namespace SBCA_DataStandard
{
    public class Hardware
    { 
        public string Name { get; set; }

        public string MaterialDescription { get; set; }

        public MaterialType MaterialType { get; set; }

        public Guid MaterialGuid { get; set; }

        public bool FieldInstalled { get; set; }

        public Point3D Center { get; set; }
		
        public Vector3D NormalDirection { get; set; }

        /// <summary>
        /// Clockwise angle from the X Axis
        /// </summary>
        public double Angle { get; set; }

    }
}
