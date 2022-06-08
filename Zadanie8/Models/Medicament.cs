﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Zadanie8.Models
{
    public class Medicament
    {
        public Medicament()
        {
            PrescriptionMedicaments = new HashSet<PrescriptionMedicament>();
        }

        [Key]
        public int IdMedicament { get; set; }
        [Required,MaxLength(100)]
        public string Name { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public ICollection<PrescriptionMedicament> PrescrptionMedicaments { get; set; }
    }
}
