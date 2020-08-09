using NiliBlazorAppWithAuthentication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NiliBlazorAppWithAuthentication.Services.Interfaces
{
    public interface IMedicationService
    {
        public List<Medication> GetMedications();
        public List<Medication> GetMedicationsByName(string name);
        public List<Medication> GetMedicationsOfType(string type);
        List<string> GetMedicationTypes();
        public List<Medication> FilteredSet { get; set; }

        public List<Medication> GetMedicationsByUser(string username);
        public void AddMedicationToUser(string username, Medication medication);
    }
}
