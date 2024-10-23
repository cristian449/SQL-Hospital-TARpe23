using System.ComponentModel.DataAnnotations;

namespace Hospital_CristianPent_TARpe23.Models
{
    public class Ward
    {
        [Key]
        public int WardID { get; set; }

        public string WardName { get; set; }

        public string WardType { get; set; }

        public int MaxPatients { get; set; }

        public int PatientID { get; set; }

        public int DoctorID { get; set; }
    }
}
