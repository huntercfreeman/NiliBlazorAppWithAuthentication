using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Web;
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
        
        public string DraggingCSS 
        {
            get => ((MedicationDragEventState.MedicationBeingDragged != null) && (!IsMousedOver)) ? "background-color: green;" : "";
        }

        public string OnMouseOverCSS
        {
            get => ((MedicationDragEventState.MedicationBeingDragged != null) && (IsMousedOver)) ? "background-color: blue;" : "";
        }

        private bool IsMousedOver 
        {
            get => MedicationDragEventState.DropzoneIsHovered;
            set => MedicationDragEventState.DropzoneIsHovered = value;
        }

        protected override void OnInitialized()
        {
            base.OnInitialized();
            MedicationDragEventState.DragStartEventHandler += MedicationDragEventState_DragStartEventHandler;
        }

        private void MedicationDragEventState_DragStartEventHandler(object sender, EventArgs e)
        {
            InvokeAsync(StateHasChanged);
        }

        private void OnDragEnter()
        {
            if(MedicationDragEventState.MedicationBeingDragged != null)
            {
                IsMousedOver = true;
                StateHasChanged();
            }
        }

        private void OnMouseOut(MouseEventArgs e)
        {
            if (e.ClientX != 0 && e.ClientY != 0)
            {
                IsMousedOver = false;
                StateHasChanged();
            }
        }

        public void Dispose()
        {
            MedicationDragEventState.DragStartEventHandler -= MedicationDragEventState_DragStartEventHandler;
        }
    }
}
