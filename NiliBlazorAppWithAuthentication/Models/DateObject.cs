using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NiliBlazorAppWithAuthentication.Models
{
    public class DateObject
    {
        public DateTime Date { get; set; }
        public List<EventObject> Events { get; set; }
    }
}
