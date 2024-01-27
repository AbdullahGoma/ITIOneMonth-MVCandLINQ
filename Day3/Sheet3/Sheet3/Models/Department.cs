using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sheet3.Models
{
    public class Department
    {
        [Required, Key, MaxLength(10)]
        public int Dnumber { get; set; }
        [Required, MaxLength(10)]
        public string Dname { get; set; }
        [Required]
        public int MGRSSN { get; set; }
        [ForeignKey("MGRSSN")]
        public Superssn Superssn { get; set; }
        [Required]
        public DateTime MGRSDATE { get; set; }


    }
}
