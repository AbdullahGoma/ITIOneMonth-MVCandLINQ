using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sheet3.Models
{
    public class Project
    {
        [Required, Key, MaxLength(10)]
        public int Pnumber { get; set; }
        [Required, MaxLength(20)]
        public string Pname { get; set; }
        [Required]
        public string Plocation { get; set; }
        [Required, MaxLength(20)]
        public string City { get; set; }
        [Required]
        public int Dnum { get; set; }
        [ForeignKey("Dnum")]
        public Department Department { get; set; }
    }
}
