using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sheet3.Models
{
    
    public class Employee:Entity<int>
    {
        [Required, MaxLength(20)]
        public string Fname { get; set; }
        public string Lname { get; set; }
        [Required]
        public DateTime BDATE { get; set; }
        [Required, MaxLength(80)]
        public string Address { get; set; }
        [Required]
        public char Gender { get; set; }
        [Required, Range(12000, 150000)]
        public float Salary { get; set; }
        [Required]
        public int SuperSSN { get; set; }
        [ForeignKey("SuperSSN")]
        public Superssn Superssn { get; set; }
        [Required]
        public int Dno { get; set; }
        [ForeignKey("Dno")]
        public Department Department { get; set; }
    }
}
