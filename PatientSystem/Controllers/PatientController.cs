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
        public ViewResult Index()
        {
            return View("PatientRegistration");
        }

        [HttpGet]
        public ViewResult PatientList()
        {
            //var patientsOrderedByName = PatientRepository.Patients.OrderBy(p => p.Name);

            //return View(patientsOrderedByName);
            return View();
        }

        [HttpPost]
        public ViewResult PatientList(Patient patient)
        {
            PatientRepository.AddPatient(patient);
            return View();
        }
    }
}