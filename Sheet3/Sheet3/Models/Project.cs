using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sheet3.Models
{
    public class Project
    {
        [Required, Key]
        public int Pnumber { get; set; }
        [Required, MaxLength(20)]
        public string Pname { get; set; }
        [Required]
        public string Plocation { get; set; }
        [Required, MaxLength(20)]
        public string City { get; set; }
        [Required]
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
    }
}
