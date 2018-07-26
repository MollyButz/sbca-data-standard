using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SBCA_DataStandard.Enums;
using SBCA_DataStandard.Materials;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBCA_DataStandard
{
    public class MaterialJsonConverter : JsonConverter
    {
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(Material);
        }

        public override void WriteJson(JsonWriter writer,
            object value, JsonSerializer serializer)
        {
            throw new InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader,
            Type objectType, object existingValue,
            JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var material = default(Material);
            var materialTypeString = jsonObject["MaterialType"].Value<string>();
            var materialType = EnumsNET.Enums.Parse<MaterialType>(materialTypeString);
            switch (materialType)
            {
                case MaterialType.Lumber:
                    material = new Lumber();
                    break;
                case MaterialType.SteelSection:
                    material = new SteelSection();
                    break;
                case MaterialType.ConnectorPlate:
                    material = new ConnectorPlate();
                    break;
                case MaterialType.Hanger:
                    material = new Hanger();
                    break;
                case MaterialType.Screw:
                    material = new Screw();
                    break;
                case MaterialType.Unknown:
                    material = new Material();
                    break;
            }

            serializer.Populate(jsonObject.CreateReader(), material);
            return material;
        }

    }
}
