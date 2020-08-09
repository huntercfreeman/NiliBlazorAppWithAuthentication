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
        public MedicationService()
        {
            foreach(Medication medication in _medications)
            {
                foreach(string type in medication.Types)
                {
                    switch(type)
                    {
                        case "SSRI":
                            _SSRIs.Add(medication);
                            break;
                        case "Antidepressant":
                            _antidepressants.Add(medication);
                            break;
                        case "Mood Stabilizer":
                            _moodStabilizers.Add(medication);
                            break;
                        case "Antipsychotic":
                            _antipsychotics.Add(medication);
                            break;
                        case "NDRI":
                            _NDRIs.Add(medication);
                            break;
                        case "Methylphenidate":
                            _methylphenidates.Add(medication);
                            break;
                        case "Amphetamine":
                            _amphetamines.Add(medication);
                            break;
                        default:
                            break;
                    }
                }
            }
        }

        private readonly List<Medication> _SSRIs = new List<Medication>();
        private readonly List<Medication> _antidepressants = new List<Medication>();
        private readonly List<Medication> _moodStabilizers = new List<Medication>();
        private readonly List<Medication> _antipsychotics = new List<Medication>();
        private readonly List<Medication> _NDRIs = new List<Medication>();
        private readonly List<Medication> _methylphenidates = new List<Medication>();
        private readonly List<Medication> _amphetamines = new List<Medication>();

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
                Dosages = new List<double> { 1, 2, 3, 4 } },
            new Medication { Name = "Amineptine", Types = new List<string> { "NDRI" },
                Dosages = new List<double> { 1, 2, 3, 4 } },
            new Medication { Name = "Bupropion", Types = new List<string> { "NDRI" },
                Dosages = new List<double> { 1, 2, 3, 4 } },
            new Medication { Name = "Wellbutrin", Types = new List<string> { "NDRI" },
                Dosages = new List<double> { 1, 2, 3, 4 } },
            new Medication { Name = "Desoxypipradrol", Types = new List<string> { "NDRI" },
                Dosages = new List<double> { 1, 2, 3, 4 } },
            new Medication { Name = "Dexmethylphenidate", Types = new List<string> { "NDRI" },
                Dosages = new List<double> { 1, 2, 3, 4 } },
            new Medication { Name = "Focalin", Types = new List<string> { "NDRI", "Methylphenidate" },
                Dosages = new List<double> { 1, 2, 3, 4 } },
            new Medication { Name = "Methylphenidate", Types = new List<string> { "NDRI" },
                Dosages = new List<double> { 1, 2, 3, 4 } },
            new Medication { Name = "Ritalin", Types = new List<string> { "NDRI", "Methylphenidate" },
                Dosages = new List<double> { 1, 2, 3, 4 } },
            new Medication { Name = "Concerta", Types = new List<string> { "NDRI", "Methylphenidate" },
                Dosages = new List<double> { 1, 2, 3, 4 } },
            new Medication { Name = "Amphetamine", Types = new List<string> { "NDRI" },
                Dosages = new List<double> { 1, 2, 3, 4 } },
            new Medication { Name = "Adderall", Types = new List<string> { "NDRI", "Amphetamine" },
                Dosages = new List<double> { 1, 2, 3, 4 } },
            new Medication { Name = "Vyvanse", Types = new List<string> { "NDRI", "Amphetamine" },
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

        public List<Medication> GetMedicationsByType(string type)
        {
            switch (type)
            {
                case "SSRI":
                    return _SSRIs;
                    break;
                case "Antidepressant":
                    return _antidepressants;
                    break;
                case "Mood Stabilizer":
                    return _moodStabilizers;
                    break;
                case "Antipsychotic":
                    return _antipsychotics;
                    break;
                case "NDRI":
                    return _NDRIs;
                    break;
                case "Methylphenidate":
                    return _methylphenidates;
                    break;
                case "Amphetamine":
                    return _amphetamines;
                    break;
                default:
                    return new List<Medication>();
                    break;
            }
        }
    }
}
