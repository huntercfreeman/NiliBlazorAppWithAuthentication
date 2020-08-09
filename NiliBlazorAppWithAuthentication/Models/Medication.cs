using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NiliBlazorAppWithAuthentication.Models
{
    public class Medication
    {
        public string Name { get; set; }
        public List<string> Types { get; set; }
        public List<double> Dosages { get; set; }
        public List<int> TimesPerDay { get; set; }
    }
}
