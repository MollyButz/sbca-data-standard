using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBCA_DataStandard
{
    /// <summary>
    /// Semantic Versioning Modeled after: https://semver.org/
    /// </summary>
    public class Version
    {
        public Version(int majorVersion, int minorVersion, int patchVersion)
        {
            MajorVersion = majorVersion;
            MinorVersion = minorVersion;
            PatchVersion = patchVersion;
        }

        public Version(string version)
        {
            var versionParts = version.Split('.');
            MajorVersion = int.Parse(versionParts[0]);
            MinorVersion = int.Parse(versionParts[1]);
            PatchVersion = int.Parse(versionParts[2]);
        }

        public int MajorVersion { get; set; }
        public int MinorVersion { get; set; }
        public int PatchVersion { get; set; }

        public override string ToString()
        {
            return $"{MajorVersion}.{MinorVersion}.{PatchVersion}";
        }
    }
}
