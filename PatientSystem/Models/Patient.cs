using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis.Emit;

namespace PatientSystem.Models
{
    public class Patient
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public string Occupation { get; set; }
        public bool HasInsurance { get; set; }
        public bool HadPreviousOperation { get; set; }
        public string MaritalStatus { get; set; }
    }
}