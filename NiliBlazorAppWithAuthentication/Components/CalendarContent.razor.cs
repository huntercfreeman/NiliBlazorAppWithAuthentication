using Microsoft.AspNetCore.Components;
using NiliBlazorAppWithAuthentication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NiliBlazorAppWithAuthentication.Components
{
    public partial class CalendarContent : ComponentBase
    {
        [Parameter]
        public List<DateObject> Dates { get; set; }
    }
}
