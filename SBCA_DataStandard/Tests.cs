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
using System.IO;

namespace SBCA_DataStandard
{
    [TestFixture]
    public class Tests
    {
        public static readonly JsonSerializerSettings SerializerSettings = new JsonSerializerSettings
        {
            ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
            PreserveReferencesHandling = PreserveReferencesHandling.None,
            Converters = new List<JsonConverter> { new StringEnumConverter(), new MaterialJsonConverter() },
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
        public void Dump_Serialize_Component()
        {
            var component = TestModels.TestComponent;
            var jsonOutput = JsonConvert.SerializeObject(component, Formatting.Indented, new Newtonsoft.Json.Converters.StringEnumConverter());
            var desktopPath = Environment.GetFolderPath(System.Environment.SpecialFolder.DesktopDirectory);

            try
            {
                string outputFile = $@"{desktopPath}\componentoutput.json";
                File.WriteAllText(outputFile, jsonOutput);

                Assert.IsTrue(File.Exists(outputFile));
            }
            catch (Exception ex)
            {
                Assert.Fail("Writing the test model failed! " + ex.Message);
            }
        }

        [Test]
        public void Dump_Serialize_Model()
        {
            var schemaFromModel = SchemaGenerator.Generate(typeof(Component));
            var jsonOutput = schemaFromModel.ToString();
            var desktopPath = Environment.GetFolderPath(System.Environment.SpecialFolder.DesktopDirectory);

            try
            {
                string outputFile = $@"{desktopPath}\modeloutput.json";
                File.WriteAllText(outputFile, jsonOutput);

                Assert.IsTrue(File.Exists(outputFile));
            }
            catch (Exception ex)
            {
                Assert.Fail("Writing the test model failed! " + ex.Message);
            }
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

            var firstMember = component.Members.First();

            Assert.AreEqual(firstMember.Name, "B1");
            Assert.AreEqual(firstMember.MemberTypes[0], MemberType.BottomChord);
            Assert.AreEqual(firstMember.MaterialDescription, "#2 SYP 2x4");
            Assert.AreEqual(firstMember.MaterialType, MaterialType.Lumber);
            Assert.AreEqual(firstMember.StockLength, 120);
            Assert.AreEqual(firstMember.Orientation.DX, 1.0);
            Assert.AreEqual(firstMember.Orientation.DY, 0.0);
            Assert.AreEqual(firstMember.Orientation.DZ, 0.0);
        }

        [Test]
        public void ValidJsonSchema_TestFile()
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

        [Test]
        public void Points()
        {
            // Default Value Test
            Point3D ptDefault = new Point3D();
            Point3D ptZero = new Point3D(0.0, 0.0, 0.0);
            Assert.AreEqual(ptDefault.X, ptZero.X);
            Assert.AreEqual(ptDefault.Y, ptZero.Y);
            Assert.AreEqual(ptDefault.Z, ptZero.Z);

            // Constructor Test
            Point3D ptNonZero = new Point3D(1.2, 3.4, 5.6);
            Assert.AreEqual(ptNonZero.X, 1.2);
            Assert.AreEqual(ptNonZero.Y, 3.4);
            Assert.AreEqual(ptNonZero.Z, 5.6);
        }

        [Test]
        public void Vectors()
        {
            // Default Value Test
            Vector3D vecDefault = new Vector3D();
            Vector3D vecZero = new Vector3D(0.0, 0.0, 0.0);
            Assert.AreEqual(vecDefault.DX, vecZero.DX);
            Assert.AreEqual(vecDefault.DY, vecZero.DY);
            Assert.AreEqual(vecDefault.DZ, vecZero.DZ);

            // Constructor Test
            Vector3D vecNonZero = new Vector3D(1.2, 3.4, 5.6);
            Assert.AreEqual(vecNonZero.DX, 1.2);
            Assert.AreEqual(vecNonZero.DY, 3.4);
            Assert.AreEqual(vecNonZero.DZ, 5.6);
            Assert.AreEqual(vecNonZero.Magnitude, Math.Sqrt(1.2 * 1.2 + 3.4 * 3.4 + 5.6 * 5.6));

            // Point-Point Constructor Test
            Point3D ptZero = new Point3D(0.0, 0.0, 0.0);
            Point3D ptX = new Point3D(1.0, 0.0, 0.0);
            Point3D ptY = new Point3D(0.0, 1.0, 0.0);
            Point3D ptZ = new Point3D(0.0, 0.0, 1.0);

            Vector3D vecX = new Vector3D(ptZero, ptX);
            Vector3D vecY = new Vector3D(ptZero, ptY);
            Vector3D vecZ = new Vector3D(ptZero, ptZ);

            Assert.AreEqual(vecX.DX, Vector3D.XAxis.DX);
            Assert.AreEqual(vecX.DY, Vector3D.XAxis.DY);
            Assert.AreEqual(vecX.DZ, Vector3D.XAxis.DZ);

            Assert.AreEqual(vecY.DX, Vector3D.YAxis.DX);
            Assert.AreEqual(vecY.DY, Vector3D.YAxis.DY);
            Assert.AreEqual(vecY.DZ, Vector3D.YAxis.DZ);

            Assert.AreEqual(vecZ.DX, Vector3D.ZAxis.DX);
            Assert.AreEqual(vecZ.DY, Vector3D.ZAxis.DY);
            Assert.AreEqual(vecZ.DZ, Vector3D.ZAxis.DZ);

            // Normalize Test
            vecNonZero.Normalize();
            Assert.AreEqual(vecNonZero.Magnitude, 1.0);
        }
    }
}
