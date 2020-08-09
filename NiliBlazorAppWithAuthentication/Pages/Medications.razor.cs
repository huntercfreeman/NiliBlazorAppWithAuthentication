using Microsoft.AspNetCore.Components;
using NiliBlazorAppWithAuthentication.Models;
using NiliBlazorAppWithAuthentication.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NiliBlazorAppWithAuthentication.Pages
{
    public partial class Medications : ComponentBase
    {
        [Inject]
        public IMedicationService MedicationService { get; set; }
        public List<Medication> MedicationsList { get; set; }
        protected override void OnInitialized()
        {
            base.OnInitialized();
            MedicationsList = MedicationService.GetMedications();
        }
    }
}
