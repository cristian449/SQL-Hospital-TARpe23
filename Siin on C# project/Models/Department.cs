using System.ComponentModel.DataAnnotations;

namespace Hospital_CristianPent_TARpe23.Models
{
    public class Department
    {
        [Key]
        public int DepartmentID { get; set; }
        
        public int DoctorID { get; set; }

        public string DepartmentName { get; set; }

        public string DepartmentSpecialty { get; set; }

        public int MaxPersonnel { get; set; }

    }
}
