using Microsoft.AspNetCore.Components;
using NiliBlazorAppWithAuthentication.Models;
using NiliBlazorAppWithAuthentication.Services.Interfaces;
using NiliBlazorAppWithAuthentication.Shared;
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
        
        public Medication MedicationBeingDragged { get; set; }
        public bool IsHoveringPillContainer { get; set; }
        public Medication MedicationBeingEdited { get; set; }
        public List<Medication> MedicationsList { get; set; }
        protected override void OnInitialized()
        {
            base.OnInitialized();
            MedicationsList = MedicationService.GetMedications();
        }
        private void OnDragEnd()
        {
            if(MedicationBeingDragged != null) MedicationBeingEdited = MedicationBeingDragged;
            MedicationBeingDragged = null;
            StateHasChanged();
            Console.WriteLine("Hello World");
        }
    }
}
