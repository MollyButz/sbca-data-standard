using SBCA_DataStandard.Enums;
using SBCA_DataStandard.Materials;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBCA_DataStandard
{
    public class MaterialTypeCollection
    {
        public string Name { get; set; }

        public MaterialType MaterialType { get; set; }

        public IEnumerable<Material> Materials { get; set; }

        public MaterialTypeCollection() { }

        public MaterialTypeCollection(string name, MaterialType materialType, IEnumerable<Material> materials)
        {
            this.Name = name;
            this.MaterialType = materialType;
            this.Materials = materials;
        }
    }
}
