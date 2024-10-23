using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Hospital_CristianPent_TARpe23.Models;

namespace Hospital_CristianPent_TARpe23.Data
{

    public class HospitalContextDB : DbContext
    {
        public HospitalContextDB(DbContextOptions<HospitalContextDB> options)
            : base(options) { }




        public DbSet<Patient> Patients { get; set; }

        public DbSet<Ward> Wards { get; set; }

        public DbSet<Doctor> Doctors { get; set; }

        public DbSet<Department> Departments { get; set; }

        public DbSet<Hospital> Hospitals { get; set; }

    }


}
