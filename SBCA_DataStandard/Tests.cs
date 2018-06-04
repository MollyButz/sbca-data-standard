using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;
using Newtonsoft.Json.Schema.Generation;
using Newtonsoft.Json.Serialization;
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
        public static readonly JsonSerializerSettings SerializerSettings = new JsonSerializerSettings
        {
            ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
            PreserveReferencesHandling = PreserveReferencesHandling.None,
            Converters = new List<JsonConverter> { new StringEnumConverter() },
            ContractResolver = new CamelCasePropertyNamesContractResolver(),
        };

        public static JSchemaGenerator SchemaGenerator
        {
            get
            {
                {
                    var returnGenerator = new JSchemaGenerator();
                    returnGenerator.GenerationProviders.Add(new StringEnumGenerationProvider());
                    return returnGenerator;
                }
            }
        }

        [Test]
        public void Deserialize_C3_SP_24()
        {
            var component = JsonConvert.DeserializeObject<Component>(Encoding.UTF8.GetString(FileResources.C3_SP_24), SerializerSettings);
            Assert.IsTrue(component != null);
        }

        [Test]
        public void Serialize_C3_SP_24()
        {
            var component = JsonConvert.DeserializeObject<Component>(Encoding.UTF8.GetString(FileResources.C3_SP_24));

            var jsonOutput = JsonConvert.SerializeObject(component, new Newtonsoft.Json.Converters.StringEnumConverter());

            var reparsedComponent = JsonConvert.DeserializeObject<Component>(jsonOutput, SerializerSettings);

            Assert.AreEqual(component.Name, reparsedComponent.Name);
        }

        [Test]
        public void ValidJsonSchema_C3_SP_24()
        {
            var schema = SchemaGenerator.Generate(typeof(Component));

            var componentJson = JObject.Parse(Encoding.UTF8.GetString(FileResources.C3_SP_24));

            IList<string> messages; // debug and inspect this variable to see why invalid
            var valid = componentJson.IsValid(schema, out messages);

            Assert.IsTrue(valid);
        }

        [Test]
        public void SchemaFileMatchesModel()
        {
            var schemaFromModel = SchemaGenerator.Generate(typeof(Component));
            var schemaJson = schemaFromModel.ToString(); // debug and inspect this variable to copy to Schema.json file in Resources
            var schemaFromFile = JSchema.Parse(Encoding.UTF8.GetString(FileResources.Schema));

            Assert.AreEqual(schemaFromModel.ToString(), schemaFromFile.ToString());
        }
    }
}
