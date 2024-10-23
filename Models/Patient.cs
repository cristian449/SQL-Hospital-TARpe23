using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hospital_CristianPent_TARpe23.Models


{
    public class Patient
    {
        [Key]
        public int PatientID { get; set; }
        public string Name { get; set; }

        public string Gender { get; set; }

        public string Address { get; set; }

        public int PhoneNr { get; set; }

        public string BirthDate { get; set; }

        public int DoctorID { get; set; }

        public string Condition { get; set; }

        public string Date_Checked_In { get; set; }

        public string Discharge_Date {  get; set; }

        public int WardID { get; set; }


    }
}
