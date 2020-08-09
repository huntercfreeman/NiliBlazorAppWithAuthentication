using Microsoft.AspNetCore.Components;
using NiliBlazorAppWithAuthentication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NiliBlazorAppWithAuthentication.Pages
{
    public partial class Index : ComponentBase
    {
        public List<DateObject> Dates { get; set; }
    }
}
