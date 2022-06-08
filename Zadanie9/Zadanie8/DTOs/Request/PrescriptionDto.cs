﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Zadanie8.Models;

namespace Zadanie8.DTOs
{
    public class PrescriptionDto
    {
        public DateTime PrescriptionDate { get; set; }
        public DateTime PrescriptionDueDate { get; set; }
        public string PatientFirstName { get; set; }
        public string PatientLastName { get; set; }
        public DateTime PatientBirthDate { get; set; }
        public string DoctorFirstName { get; set; }
        public string DoctorLastName { get; set; }
        public string DoctorEmail { get; set; }
        public IEnumerable<MedicamentDto> Medicaments { get; set; }
    }
}