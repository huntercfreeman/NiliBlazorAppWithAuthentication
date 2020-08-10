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
            typeMaping.Add("SSRI", _SSRIs);
            typeMaping.Add("Antidepressant", _antidepressants);
            typeMaping.Add("Mood Stabilizer", _moodStabilizers);
            typeMaping.Add("Antipsychotic", _antipsychotics);
            typeMaping.Add("NDRI", _NDRIs);
            typeMaping.Add("Methylphenidate", _methylphenidates);
            typeMaping.Add("Amphetamine", _amphetamines);

            foreach (Medication medication in _medications)
            {
                foreach (string type in medication.Types)
                {
                    switch (type)
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

        private void CalculateFilteredLists()
        {
            _filteredTypeMaping = new Dictionary<string, List<Medication>>();

            _filteredSSRIs = new List<Medication>();
            _filteredAntidepressants = new List<Medication>();
            _filteredMoodStabilizers = new List<Medication>();
            _filteredAntipsychotics = new List<Medication>();
            _filteredNDRIs = new List<Medication>();
            _filteredMethylphenidates = new List<Medication>();
            _filteredAmphetamines = new List<Medication>();

            _filteredTypeMaping.Add("SSRI", _filteredSSRIs);
            _filteredTypeMaping.Add("Antidepressant", _filteredAntidepressants);
            _filteredTypeMaping.Add("Mood Stabilizer", _filteredMoodStabilizers);
            _filteredTypeMaping.Add("Antipsychotic", _filteredAntipsychotics);
            _filteredTypeMaping.Add("NDRI", _filteredNDRIs);
            _filteredTypeMaping.Add("Methylphenidate", _filteredMethylphenidates);
            _filteredTypeMaping.Add("Amphetamine", _filteredAmphetamines);

            foreach (Medication medication in FilteredSet)
            {
                foreach (string type in medication.Types)
                {
                    switch (type)
                    {
                        case "SSRI":
                            _filteredSSRIs.Add(medication);
                            break;
                        case "Antidepressant":
                            _filteredAntidepressants.Add(medication);
                            break;
                        case "Mood Stabilizer":
                            _filteredMoodStabilizers.Add(medication);
                            break;
                        case "Antipsychotic":
                            _filteredAntipsychotics.Add(medication);
                            break;
                        case "NDRI":
                            _filteredNDRIs.Add(medication);
                            break;
                        case "Methylphenidate":
                            _filteredMethylphenidates.Add(medication);
                            break;
                        case "Amphetamine":
                            _filteredAmphetamines.Add(medication);
                            break;
                        default:
                            break;
                    }
                }
            }
        }

        private readonly Dictionary<string, List<Medication>> usernameMedicationMap = new Dictionary<string, List<Medication>>();

        // FILTERED
        private Dictionary<string, List<Medication>> _filteredTypeMaping = new Dictionary<string, List<Medication>>();

        private List<Medication> _filteredSSRIs = new List<Medication>();
        private List<Medication> _filteredAntidepressants = new List<Medication>();
        private List<Medication> _filteredMoodStabilizers = new List<Medication>();
        private List<Medication> _filteredAntipsychotics = new List<Medication>();
        private List<Medication> _filteredNDRIs = new List<Medication>();
        private List<Medication> _filteredMethylphenidates = new List<Medication>();
        private List<Medication> _filteredAmphetamines = new List<Medication>();


        // UNFILTERED
        private readonly Dictionary<string, List<Medication>> typeMaping = new Dictionary<string, List<Medication>>();

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

        private readonly List<string> _medicationTypes = new List<string>
        {
            "SSRI",
            "Antidepressant",
            "Mood Stabilizer",
            "Antipsychotic",
            "NDRI",
            "Methylphenidate",
            "Amphetamine"
        };

        private List<Medication> _filteredSet;
        public List<Medication> FilteredSet
        {
            get => _filteredSet;
            set
            {
                _filteredSet = value;
                CalculateFilteredLists();
            }
        }

        public List<Medication> GetMedications()
        {
            if (FilteredSet == null)
                return _medications;
            return FilteredSet;
        }

        public List<Medication> GetMedicationsByName(string name)
        {
            return _medications.Where(x => x.Name.Contains(name, StringComparison.InvariantCultureIgnoreCase)).ToList();
        }

        public List<string> GetMedicationTypes()
        {
            return _medicationTypes;
        }

        public List<Medication> GetMedicationsOfType(string type)
        {
            return _filteredSet == null ? typeMaping[type] : _filteredTypeMaping[type];
        }

        public List<Medication> GetMedicationsByUser(string username)
        {
            try
            {
                return usernameMedicationMap[username];
            }
            catch(Exception)
            {
                return new List<Medication>();
            }
        }

        public void AddMedicationToUser(string username, Medication medication)
        {
            try
            {
                usernameMedicationMap[username].Add(medication);
            }
            catch (Exception)
            {
                List<Medication> tempMedications = new List<Medication>();
                tempMedications.Add(medication);

                usernameMedicationMap.Add(username, tempMedications);
            }
        }

        public void DeleteMedicationToUser(string username, Medication medication)
        {
            try
            {
                usernameMedicationMap[username].Add(medication);
            }
            catch (Exception)
            {
                List<Medication> tempMedications = new List<Medication>();
                tempMedications.Add(medication);

                usernameMedicationMap.Add(username, tempMedications);
            }
        }
    }
}
