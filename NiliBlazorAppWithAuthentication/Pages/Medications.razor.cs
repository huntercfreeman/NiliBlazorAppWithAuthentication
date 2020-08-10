using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
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
        [Inject]
        public MedicationDragEventState MedicationDragEventState { get; set; }
        [Inject]
        AuthenticationStateProvider AuthenticationStateProvider { get; set; }
        public Medication MedicationBeingDragged 
        {
            get => MedicationDragEventState.MedicationBeingDragged;
            set => MedicationDragEventState.MedicationBeingDragged = value;
        }
        public bool IsHoveringPillContainer { get; set; }
        public Medication MedicationBeingEdited { get; set; }
        public List<Medication> MedicationsList { get; set; }
        protected override void OnInitialized()
        {
            base.OnInitialized();
            MedicationsList = MedicationService.GetMedications();
        }
        private async void OnDragEnd()
        {
            if (MedicationDragEventState.DropzoneIsHovered)
            {
                AuthenticationState authenticationState = await AuthenticationStateProvider.GetAuthenticationStateAsync();
                MedicationService.AddMedicationToUser(authenticationState.User.Identity.Name, MedicationDragEventState.MedicationBeingDragged);
            }
            MedicationDragEventState.MedicationBeingDragged = null;
            MedicationDragEventState.DropzoneIsHovered = false;
            MedicationDragEventState.ReRenderEventInvoke(new EventArgs());
        }
    }
}
