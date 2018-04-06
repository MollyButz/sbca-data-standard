using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBCA_DataStandard
{
    public class Member
    {
        public string Name { get; set; }

        public Lumber Lumber { get; set; }

        public Geometry Geometry { get; set; }

        public string MemberType { get; set; }

        public double Length { get; set; }

        public string Bracing { get; set; }

        public double Angle { get; set; }

        public double CrossSectionalArea { get; set; }

        public double[] TransformationMatrix { get; set; }
    }
}
