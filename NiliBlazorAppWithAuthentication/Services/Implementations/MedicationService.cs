using NiliBlazorAppWithAuthentication.Models;
using NiliBlazorAppWithAuthentication.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NiliBlazorAppWithAuthentication.Services.Implementations
{
    public class MedicationService : IMedicationService
    {
        private readonly List<Medication> _medications = new List<Medication>
        {
            new Medication { Name = "Zoloft", Types = new List<string> { "SSRI", "Antidepressant" },
                Dosages = new List<double> { 25, 50, 100 } },
            new Medication { Name = "Prozac", Types = new List<string> { "SSRI", "Antidepressant" },
                Dosages = new List<double> { 10, 20, 40 } },
            new Medication { Name = "Lithium", Types = new List<string> { "Mood Stabilizer" },
                Dosages = new List<double> { 300, 450, 600 } },
            new Medication { Name = "Risperdal", Types = new List<string> { "Antipsychotic" }, 
                Dosages = new List<double> { 1, 2, 3, 4 } },
            new Medication { Name = "Luvox CR", Types = new List<string> { "SSRI", "Antidepressant" },
                Dosages = new List<double> { 1, 2, 3, 4 } },
            new Medication { Name = "Sarafem", Types = new List<string> { "SSRI", "Antidepressant" },
                Dosages = new List<double> { 1, 2, 3, 4 } },
            new Medication { Name = "Pexeva", Types = new List<string> { "SSRI", "Antidepressant" },
                Dosages = new List<double> { 1, 2, 3, 4 } },
            new Medication { Name = "Paxil CR", Types = new List<string> { "SSRI", "Antidepressant" },
                Dosages = new List<double> { 1, 2, 3, 4 } },
            new Medication { Name = "Lexapro", Types = new List<string> { "SSRI", "Antidepressant" },
                Dosages = new List<double> { 1, 2, 3, 4 } },
            new Medication { Name = "Celexa", Types = new List<string> { "SSRI", "Antidepressant" },
                Dosages = new List<double> { 1, 2, 3, 4 } },
            new Medication { Name = "Luvox", Types = new List<string> { "SSRI", "Antidepressant" },
                Dosages = new List<double> { 1, 2, 3, 4 } },
            new Medication { Name = "Paxil", Types = new List<string> { "SSRI", "Antidepressant" },
                Dosages = new List<double> { 1, 2, 3, 4 } },
            new Medication { Name = "Brisdelle", Types = new List<string> { "SSRI", "Antidepressant" },
                Dosages = new List<double> { 1, 2, 3, 4 } },
            new Medication { Name = "Prozac Weekly", Types = new List<string> { "SSRI", "Antidepressant" },
                Dosages = new List<double> { 1, 2, 3, 4 } },
            new Medication { Name = "Selfemra", Types = new List<string> { "SSRI", "Antidepressant" },
                Dosages = new List<double> { 1, 2, 3, 4 } },
            new Medication { Name = "Rapiflux", Types = new List<string> { "SSRI", "Antidepressant" },
                Dosages = new List<double> { 1, 2, 3, 4 } }
        };

        public List<Medication> GetMedications()
        {
            return _medications;
        }

        public List<Medication> GetMedicationsByName(string name)
        {
            return _medications.Where(x => x.Name.Contains(name, StringComparison.InvariantCultureIgnoreCase)).ToList();
        }
    }
}
