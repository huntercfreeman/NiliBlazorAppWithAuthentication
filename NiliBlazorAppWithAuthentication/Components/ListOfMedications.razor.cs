using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using NiliBlazorAppWithAuthentication.Models;
using NiliBlazorAppWithAuthentication.Services.Interfaces;
using NiliBlazorAppWithAuthentication.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NiliBlazorAppWithAuthentication.Components
{
    public partial class ListOfMedications : ComponentBase, IDisposable
    {
        [Inject]
        public MedicationDragEventState MedicationDragEventState { get; set; }
        [Inject]
        public IMedicationService MedicationService { get; set; }
        [Inject] 
        AuthenticationStateProvider AuthenticationStateProvider { get; set; }
        public string DraggingCSS 
        {
            get => MedicationDragEventState.MedicationBeingDragged != null ? "background-color: green;" : "";
        }

        public string OnMouseOverCSS
        {
            get => MedicationDragEventState.MedicationBeingDragged != null ? "background-color: lawn-green;" : "";
        }

        private bool IsMousedOver { get; set; }

        protected override void OnInitialized()
        {
            base.OnInitialized();
            MedicationDragEventState.DragStartEventHandler += MedicationDragEventState_DragStartEventHandler;
        }

        private void MedicationDragEventState_DragStartEventHandler(object sender, EventArgs e)
        {
            InvokeAsync(StateHasChanged);
        }

        private void OnMouseOver()
        {
            IsMousedOver = true;
            StateHasChanged();
        }

        private async void OnDragEnter()
        {
            if (MedicationDragEventState.MedicationBeingDragged != null)
            {
                AuthenticationState authenticationState = await AuthenticationStateProvider.GetAuthenticationStateAsync();
                MedicationService.AddMedicationToUser(authenticationState.User.Identity.Name, MedicationDragEventState.MedicationBeingDragged);
                MedicationDragEventState.MedicationBeingDragged = null;
                await InvokeAsync(StateHasChanged);
            }
        }

        public void Dispose()
        {
            MedicationDragEventState.DragStartEventHandler -= MedicationDragEventState_DragStartEventHandler;
        }
    }
}
