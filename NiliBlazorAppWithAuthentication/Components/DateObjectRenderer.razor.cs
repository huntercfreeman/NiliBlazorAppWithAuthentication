using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using NiliBlazorAppWithAuthentication.Models;
using NiliBlazorAppWithAuthentication.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NiliBlazorAppWithAuthentication.Components
{
    public partial class DateObjectRenderer : ComponentBase
    {
        [Inject]
        public EventObjectFormState EventObjectFormState { get; set; }
        [Parameter]
        public DateObject DateObject { get; set; }

        private void AddEventObject(MouseEventArgs e)
        {
            EventObjectFormState.XCoordinate = e.ClientX;
            EventObjectFormState.YCoordinate = e.ClientY;
            EventObjectFormState.IsDisplayed = true;
            EventObjectFormState.ReRenderEventInvoke(new EventArgs());
        }
    }
}
