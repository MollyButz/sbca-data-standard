using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Schema;
using Newtonsoft.Json.Schema.Generation;

namespace SBCA_DataStandard
{
    public class Bearing
    {
        [JsonProperty(Required = Required.Always)]
        public Guid Guid { get; set; }

        public string Description { get; set; }

        public Guid AssociatedHardwareSetGuid { get; set; }

        public Geometry Geometry { get; set; }
    }
}
