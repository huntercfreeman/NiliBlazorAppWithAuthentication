using Microsoft.AspNetCore.Components;
using NiliBlazorAppWithAuthentication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NiliBlazorAppWithAuthentication.Components
{
    public partial class EventObjectRenderer : ComponentBase
    {
        [Parameter]
        public EventObject EventObject { get; set; }
    }
}
