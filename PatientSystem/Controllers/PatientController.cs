using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PatientSystem.Models;

namespace PatientSystem.Controllers
{
    public class PatientController : Controller
    {
        [HttpGet]
        public ViewResult Index()
        {
            return View("PatientRegistration");
        }

        [HttpPost]
        public ViewResult Index(Patient patient)
        {
            patient.CreationTime = DateTime.Now;
            PatientRepository.AddPatient(patient);
            return View("Thanks", patient);
        }

        public ViewResult Thanks(Patient patient)
        {
            return View(patient);
        }

        public ViewResult PatientList()
        {
            var patientsOrderedByName = PatientRepository.Patients.OrderBy(p => p.Name);
            return View(patientsOrderedByName);
        }
    }
}