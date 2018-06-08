using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;

using SBCA_DataStandard.Enums;

namespace SBCA_DataStandard
{
    public class Lumber
    {
        public string NominalThickness { get; set; }

        public string NominalWidth { get; set; }

        public double ActualThickness { get; set; }

        public double ActualWidth { get; set; }

        public double Length { get; set; }

        public LumberGrade Grade { get; set; }

        public LumberSpecies Species { get; set; }

        public string TreatmentType { get; set; }

        public GradingMethod GradingMethod { get; set; }

        public string Structure { get; set; }
    }
}
