using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using SBCA_DataStandard.Enums;
using SBCA_DataStandard.Materials;

namespace SBCA_DataStandard
{
    public class Component
    {
        [JsonProperty(Required = Required.Always)]
        public Guid Guid { get; set; }

        [JsonProperty(Required = Required.Always)]
        public string Name { get; set; }

        [JsonProperty(Required = Required.Always)]
        public string Version { get; set; } = new Version(0, 1, 1).ToString();

        public string CreationProgram { get; set; }

        public string CreationProgramVersion { get; set; }

        [JsonProperty(Required = Required.Always)]
        public DateTime CreationTimeStamp { get; set; }

        public DistanceUnit DistanceUnit { get; set; }

        public AngleUnit AngleUnit { get; set; }

        public int NumberOfPlies { get; set; }

        public bool PliesFieldInstalled { get; set; }

        [JsonProperty(Required = Required.Always)]
        public IEnumerable<ComponentUsage> ComponentUsages { get; set; }

        [JsonIgnore]
        public IEnumerable<ConnectorPlate> ConnectorPlateTypes => MaterialTypeCollections.SingleOrDefault(collection => collection.MaterialType == MaterialType.ConnectorPlate)?.Materials.Cast<ConnectorPlate>();

        [JsonIgnore]
        public IEnumerable<Lumber> Lumbers => MaterialTypeCollections.SingleOrDefault(collection => collection.MaterialType == MaterialType.Lumber)?.Materials.Cast<Lumber>();

        [JsonIgnore]
        public IEnumerable<SteelSection> SteelSections => MaterialTypeCollections.SingleOrDefault(collection => collection.MaterialType == MaterialType.SteelSection)?.Materials.Cast<SteelSection>();

        [JsonIgnore]
        public IEnumerable<Hanger> Hangers => MaterialTypeCollections.SingleOrDefault(collection => collection.MaterialType == MaterialType.Hanger)?.Materials.Cast<Hanger>();

        [JsonIgnore]
        public IEnumerable<Screw> Screws => MaterialTypeCollections.SingleOrDefault(collection => collection.MaterialType == MaterialType.Screw)?.Materials.Cast<Screw>();

        [JsonProperty(Required = Required.Always)]
        public IEnumerable<MaterialTypeCollection> MaterialTypeCollections { get; set; } = new List<MaterialTypeCollection>();

        [JsonProperty(Required = Required.Always)]
        public IEnumerable<HardwareSet> HardwareSets { get; set; } = new List<HardwareSet>();

        [JsonProperty(Required = Required.Always)]
        public IEnumerable<Member> Members { get; set; } = new List<Member>();

        [JsonProperty(Required = Required.Always)]
        public IEnumerable<Bearing> Bearings { get; set; } = new List<Bearing>();
    }
}
