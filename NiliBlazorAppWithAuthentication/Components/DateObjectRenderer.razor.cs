using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using NiliBlazorAppWithAuthentication.Models;
using NiliBlazorAppWithAuthentication.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Threading.Tasks;

namespace NiliBlazorAppWithAuthentication.Components
{
    public partial class DateObjectRenderer : ComponentBase
    {
        [Inject]
        public EventObjectFormState EventObjectFormState { get; set; }
        [Parameter]
        public DateObject DateObject { get; set; }
        public bool IsSelected { get; set; }
        public string IsSelectedCSS 
        {
            get => IsSelected ? "border: 1px solid blue;" : "border: 1px solid red;";
        }

        protected override void OnInitialized()
        {
            base.OnInitialized();
            EventObjectFormState.ReRenderEventHandler += EventObjectFormState_ReRenderEventHandler;
        }

        private void EventObjectFormState_ReRenderEventHandler(object sender, EventArgs e)
        {
            IsSelected = false;
            StateHasChanged();
        }

        private void AddEventObject(MouseEventArgs e)
        {
            EventObjectFormState.XCoordinate = e.ClientX;
            EventObjectFormState.YCoordinate = e.ClientY;
            EventObjectFormState.IsDisplayed = true;
            EventObjectFormState.CurrentDateObject = this.DateObject;
            EventObjectFormState.ReRenderEventInvoke(new EventArgs());

            IsSelected = true;
            StateHasChanged();
        }
    }
}
