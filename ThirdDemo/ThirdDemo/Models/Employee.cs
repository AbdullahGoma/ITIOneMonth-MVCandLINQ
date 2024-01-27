using System.ComponentModel.DataAnnotations;

namespace ThirdDemo.Models
{
    public class Employee:Entity<int>
    {
        [MaxLength(20)]
        public string Name { get; set; }
        public string Address { get; set; }
        public int Salary { get; set; }
        public DateTime BirthDate { get; set; }
        [MaxLength(11)]
        public int Phone { get; set; }
    }
}
