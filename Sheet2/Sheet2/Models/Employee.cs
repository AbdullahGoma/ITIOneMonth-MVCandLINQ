using System.ComponentModel.DataAnnotations;

namespace Sheet2.Models
{
    public class Employee
    {
        //Id, name, Address, salary, DepartmentNumber
        //9-Create Employee class that contains the following properities(Id, name, Address, salary, DepartmentNumber).
        [Required]
        public int Id { get; set; }
        [Required]
        [MaxLength(15)]
        public string Name { get; set; }
        [Required]
        [MaxLength(15)]
        public string Address { get; set; }
        [Required]
        [Range(10000,200000)]
        public int Salary { get; set; }
        [Required]
        [Range(1,1000)]
        public int DepartmentNumber { get; set; }
    }
}
