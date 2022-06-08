using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Zadanie8.Configurations;
using Zadanie8.EFConfigurations;

namespace Zadanie8.Models
{
    public class Context : DbContext
    {
        public Context() { }
        public Context(DbContextOptions<Context> options) : base(options) { }


        public virtual DbSet<Medicament> Medicament { get; set; }
        public virtual DbSet<PrescriptionMedicament> PrescriptionMedicament { get; set; }
        public virtual DbSet<Prescription> Prescription { get; set; }
        public virtual DbSet<Doctor> Doctor { get; set; }
        public virtual DbSet<Patient> Patient { get; set; }
        public virtual DbSet<User> User { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new DoctorEntityConfiguration());
            modelBuilder.ApplyConfiguration(new MedicamentEntityConfiguration());
            modelBuilder.ApplyConfiguration(new PatientEntityConfiguration());
            modelBuilder.ApplyConfiguration(new PerscriptionEntityConfiguration());
            modelBuilder.ApplyConfiguration(new PerscriptionMedicamentEntityConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfig());
        }
    }
}