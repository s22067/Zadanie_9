using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;



namespace Zadanie8.Models
{

    public class Prescription
    {
         public Prescription()
        {
            PrescriptionMedicaments = new HashSet<PrescriptionMedicament>();
        }

        [Key]
        public int IdPrescription { get; set; }

        public DateTime Date { get; set; }
        public DateTime DueDate { get; set; }

        [ForeignKey("IdPatient")]
        public int IdPatient { get; set; }
        public Patient Patient { get; set; }
        [ForeignKey("IdDoctor")]
        public int IdDoctor { get; set; }
        public Doctor Doctor { get; set; }

        public virtual ICollection<PrescriptionMedicament> PrescrptionMedicaments { get; set; }

    }
}