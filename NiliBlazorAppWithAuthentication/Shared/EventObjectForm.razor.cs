using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NiliBlazorAppWithAuthentication.Models;
using Microsoft.AspNetCore.Components.Forms;

namespace NiliBlazorAppWithAuthentication.Shared
{
    public partial class EventObjectForm : ComponentBase
    {
        [Inject]
        public EventObjectFormState EventObjectFormState { get; set; }

        public EditContext EditContext { get; set; }
        public EventObject EventObject { get; set; } = new EventObject();

        protected override void OnInitialized()
        {
            base.OnInitialized();
            EditContext = new EditContext(EventObject);
            EventObjectFormState.ReRenderEventHandler += EventObjectFormState_ReRenderEventHandler;
        }

        private void EventObjectFormState_ReRenderEventHandler(object sender, EventArgs e)
        {
            InvokeAsync(StateHasChanged);
        }
    }
}
