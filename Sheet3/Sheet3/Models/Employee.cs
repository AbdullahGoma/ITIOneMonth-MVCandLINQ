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
        public int EmployeeSSN { get; set; }
        public Employee Employeee { get; set; }
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
    }
}
