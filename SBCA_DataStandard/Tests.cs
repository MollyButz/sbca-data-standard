using Newtonsoft.Json;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBCA_DataStandard
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Deserialize_C3_SP_24()
        {
            var component = JsonConvert.DeserializeObject<Component>(Encoding.UTF8.GetString(FileResources.C3_SP_24));
        }

        [Test]
        public void Serialize_C3_SP_24()
        {
            var component = JsonConvert.DeserializeObject<Component>(Encoding.UTF8.GetString(FileResources.C3_SP_24));

            var jsonOutput = JsonConvert.SerializeObject(component);

            var reparsedComponent = JsonConvert.DeserializeObject<Component>(jsonOutput);

            Assert.AreEqual(component.Name, reparsedComponent.Name);
        }
    }
}
