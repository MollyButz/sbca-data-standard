using SBCA_DataStandard.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBCA_DataStandard.Materials
{
    public class  Material
    {
        public Guid Guid { get; set; }
        public virtual MaterialType MaterialType { get => MaterialType.Unknown; }
    }
}
