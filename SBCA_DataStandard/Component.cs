using System;
using System.Collections.Generic;

using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
namespace SBCA_DataStandard
{
    public class Component
    {
        public string Name { get; set; }

        public string ComponentType { get; set; }

        public int NumberOfPlies { get; set; }

        public double TopChordBracingLength { get; set; }

        public double BottomChordBracingLength { get; set; }

        public List<Member> Members { get; set; } = new List<Member>();

        public List<PlatePair> PlatePairs { get; set; } = new List<PlatePair>();

        public List<Hanger> Hangers { get; set; } = new List<Hanger>();

        public List<Bearing> Bearings { get; set; } = new List<Bearing>();
    }
}
