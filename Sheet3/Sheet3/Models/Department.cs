using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sheet3.Models
{
    public class Department
    {
        [Required, Key]
        public int Dnumber { get; set; }
        [Required, MaxLength(10)]
        public string Dname { get; set; }
        public int MGRSSN { get; set; }
        [Required]
        public DateTime MGRSDATE { get; set; }

    }
}
