using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;
using Newtonsoft.Json.Schema.Generation;
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

        [Test]
        public void ValidJsonSchema_C3_SP_24()
        {

            var generator = new JSchemaGenerator();

            var schema = generator.Generate(typeof(Component));

            var componentJson = JObject.Parse(Encoding.UTF8.GetString(FileResources.C3_SP_24));

            IList<string> messages;
            var valid = componentJson.IsValid(schema, out messages);

            Assert.IsTrue(valid);
        }

        [Test]
        public void SchemaFileMatchesModel()
        {
            var generator = new JSchemaGenerator();
            var schemaFromModel = generator.Generate(typeof(Component));
            var schemaFromFile = JSchema.Parse(Encoding.UTF8.GetString(FileResources.Schema));

            Assert.AreEqual(schemaFromModel.ToString(), schemaFromFile.ToString());
        }
    }
}
