using NiliBlazorAppWithAuthentication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NiliBlazorAppWithAuthentication.Services.Implementations
{
    public interface IDateService
    {
        public List<DateObject> GetDateObjectsForMonth(DateTime year);
    }
}
