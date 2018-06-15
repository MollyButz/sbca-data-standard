using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;
using Newtonsoft.Json.Schema.Generation;
using Newtonsoft.Json.Serialization;
using NUnit.Framework;
using SBCA_DataStandard.Enums;
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
                    returnGenerator.DefaultRequired = Required.DisallowNull;
                    return returnGenerator;
                }
            }
        }

        [Test]
        public void Deserialize_Component()
        {
            var component = JsonConvert.DeserializeObject<Component>(Encoding.UTF8.GetString(FileResources.TestFile), SerializerSettings);
            Assert.IsTrue(component != null);
        }

        [Test]
        public void Serialize_Component()
        {
            var component = TestModels.TestComponent;
            var jsonOutput = JsonConvert.SerializeObject(component, new Newtonsoft.Json.Converters.StringEnumConverter());

            var reparsedComponent = JsonConvert.DeserializeObject<Component>(jsonOutput, SerializerSettings);

            Assert.IsTrue(reparsedComponent != null);
        }

        [Test]
        public void SerializeAndDeserialize_Component()
        {
            var component = TestModels.TestComponent;

            var jsonOutput = JsonConvert.SerializeObject(component, new Newtonsoft.Json.Converters.StringEnumConverter());

            var reparsedComponent = JsonConvert.DeserializeObject<Component>(jsonOutput, SerializerSettings);

            Assert.AreEqual(component.Name, reparsedComponent.Name);
            Assert.AreEqual(component.NumberOfPlies, reparsedComponent.NumberOfPlies);
            Assert.AreEqual(component.DistanceUnit, reparsedComponent.DistanceUnit);
            Assert.AreEqual(component.AngleUnit, reparsedComponent.AngleUnit);
            Assert.That(component.ComponentUsages, Is.EquivalentTo(reparsedComponent.ComponentUsages));
            Assert.That(component.MaterialTypes, Is.EquivalentTo(reparsedComponent.MaterialTypes));

            Assert.AreEqual(component.Members[0].Name, "B1");
            Assert.AreEqual(component.Members[0].MemberType, "BottomChord");
            Assert.AreEqual(component.Members[0].MaterialDescription, "#2 SYP 2x4");
            Assert.AreEqual(component.Members[0].MaterialType, MaterialType.Lumber);
            Assert.AreEqual(component.Members[0].StockLength, 120);
            Assert.AreEqual(component.Members[0].GrainDirection, new[] { 1.0, 0.0, 0.0 });

        }

        [Test]
        public void ValidJsonSchema_C3_SP_24()
        {
            var schema = JSchema.Parse(Encoding.UTF8.GetString(FileResources.Schema));
            var componentJson = JObject.Parse(Encoding.UTF8.GetString(FileResources.TestFile));

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

        [Test]
        public void VersionConstructorsTest()
        {
            var version1 = new Version(1,2,3);
            var version2 = new Version("1.2.3");

            Assert.AreEqual(version1.MajorVersion, 1);
            Assert.AreEqual(version1.MinorVersion, 2);
            Assert.AreEqual(version1.PatchVersion, 3);

            Assert.AreEqual(version2.MajorVersion, 1);
            Assert.AreEqual(version2.MinorVersion, 2);
            Assert.AreEqual(version2.PatchVersion, 3);
        }

        [Test]
        public void VersionToStringTest()
        {
            var version1 = new Version(1, 2, 3);

            Assert.AreEqual(version1.ToString(), "1.2.3");
        }
    }
}
