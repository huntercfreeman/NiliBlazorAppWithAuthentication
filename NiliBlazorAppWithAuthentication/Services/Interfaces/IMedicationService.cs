﻿using NiliBlazorAppWithAuthentication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NiliBlazorAppWithAuthentication.Services.Interfaces
{
    public interface IMedicationService
    {
        public List<Medication> GetMedications();
        public List<Medication> GetMedicationsByName(string name);
    }
}
