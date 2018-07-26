using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBCA_DataStandard
{
    public class Point3D
    {
        // Right hand rule, orthogonal coordinates
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public Point3D ()
        {
            X = Y = Z = 0.0;
        }

        public Point3D (double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public readonly static Point3D Origin = new Point3D(0.0, 0.0, 0.0);
    }
}
