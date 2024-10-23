using Hospital_CristianPent_TARpe23.Data;
using Microsoft.AspNetCore.Mvc;
using Hospital_CristianPent_TARpe23.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Data.SqlClient;

namespace Hospital_CristianPent_TARpe23.Controllers
{
    public class PatientsController : Controller
    {
        public HospitalContextDB _context;

        public IConfiguration _config { get; }

        public PatientsController
            (
            HospitalContextDB context,
            IConfiguration config
            )
        {
            _context = context;
            _config = config;
        }


        public IActionResult Index()
        {
            return View();
        }


        public IEnumerable<Patient> SearchResult()
        {
            var result = _context.Patients
                .FromSqlRaw<Patient>("spSearchPatients")
                .ToList();

            return result;
        }

        [HttpGet]
        public IActionResult PatientSql()
        {
            string conntectionStr = _config.GetConnectionString("DefaultConnection");

            using (SqlConnection con = new SqlConnection(conntectionStr))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "dbo.spSearchPatients";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                List<Patient> model = new List<Patient>();
                while (sdr.Read())
                {
                    var details = new Patient();
                    details.PatientID = Convert.ToInt32(sdr["ID"]);
                    details.Name = sdr["Name"].ToString();
                    details.Gender = sdr["Gender"].ToString();
                    details.Address = sdr["Address"].ToString();
                    details.PhoneNr = Convert.ToInt32(sdr["PhoneNr"]);
                    details.BirthDate = sdr["BirthDate"].ToString();
                    details.DoctorID = Convert.ToInt32(sdr["DoctorID"]);
                    details.Condition = sdr["Condition"].ToString();
                    details.Date_Checked_In = sdr["Date_Checked_In"].ToString();
                    details.Discharge_Date = sdr["Discharge_Date"].ToString();
                    details.WardID = Convert.ToInt32(sdr["WardID"]);
                    model.Add(details);
                }
                return View(model);
            }
            //return View();  Pole vajalik but never can be too safe
        }
    }
}
