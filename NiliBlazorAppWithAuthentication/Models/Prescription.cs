using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NiliBlazorAppWithAuthentication.Models
{
    public class Prescription
    {
        public Medication Medication { get; set; }
        public double Dosage { get; set; }
        public string Description { get; set; }
        public string Directions { get; set; }
        public int NumberOfPillsPrescribed { get; set; }
        public int NumberOfPillsPerDose { get; set; }
        public int NumberOfDosesPerDay { get; set; }
    }
}
