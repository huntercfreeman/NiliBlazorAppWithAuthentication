﻿using NiliBlazorAppWithAuthentication.Models;
using NiliBlazorAppWithAuthentication.Services.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NiliBlazorAppWithAuthentication.Services.Interfaces
{
    public class DateService : IDateService
    {
        public List<DateObject> GetDateObjectsForMonth(DateTime year)
        {
            return new List<DateObject>
            {
                new DateObject { Date = DateTime.Today }
            };
        }
    }
}
