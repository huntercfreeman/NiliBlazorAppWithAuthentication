using Microsoft.AspNetCore.Components;
using NiliBlazorAppWithAuthentication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NiliBlazorAppWithAuthentication.Components
{
    public partial class MedicationListItem : ComponentBase
    {
        [Parameter]
        public Medication Medication { get; set; }
        [Parameter]
        public EventCallback<Medication> DeletedMedication { get; set; }
        public bool IsDisplayed { get; set; } = true;
        public string IsDisplayedCSS 
        {
            get => IsDisplayed ? "" : "display: none;";
        }
    }
}
