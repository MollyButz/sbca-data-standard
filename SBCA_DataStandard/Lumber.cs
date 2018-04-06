using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBCA_DataStandard
{
    public class Lumber
    {
        public string NominalThickness { get; set; }

        public string NominalWidth { get; set; }

        public double ActualThickness { get; set; }

        public double ActualWidth { get; set; }

        public double Length { get; set; }

        public string Grade { get; set; }

        public string Species { get; set; }

        public string TreatmentType { get; set; }

        public string GradingMethod { get; set; }

        public string Structure { get; set; }
    }
}
