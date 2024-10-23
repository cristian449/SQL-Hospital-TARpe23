using System.ComponentModel.DataAnnotations;

namespace Hospital_CristianPent_TARpe23.Models
{
    public class Doctor
    {
        [Key]
        public int DoctorID { get; set; }

        public string Name { get; set; }

        public string Gender { get; set; }

        public string BirthDate { get; set; }

        public int PhoneNr { get; set; }

        public string Address { get; set; }

        public string Specialty { get; set; }

        public string HireDate { get; set; }

        public string EndDate { get; set; }
    }
}
