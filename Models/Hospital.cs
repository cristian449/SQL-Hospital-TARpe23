using System.ComponentModel.DataAnnotations;

namespace Hospital_CristianPent_TARpe23.Models
{
    public class Hospital
    {
        [Key]
        public string Address { get; set; }

        public string Name { get; set; }

        public int Wards { get; set; }

        public int Departments { get; set; }
        
    }
}
