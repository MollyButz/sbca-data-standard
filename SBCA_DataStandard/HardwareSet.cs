using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBCA_DataStandard
{
    public class HardwareSet
    {
        public string Name { get; set; }

        public Guid Guid { get; set; }

        public List<Hardware> HardwarePieces { get; set; }
    }
}
