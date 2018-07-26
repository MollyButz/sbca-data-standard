using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBCA_DataStandard
{
    public class Geometry
    {
        public List<Point3D> Vertices { get; set; } = new List<Point3D>();

        public List<List<int>> Faces { get; set; } = new List<List<int>>();
    }
}
