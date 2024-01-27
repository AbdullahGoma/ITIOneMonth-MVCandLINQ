using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Sheet3.Models
{
    public class WorksFor
    {
        [Required, Key, Column(Order = 1)]
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
        [Required, Key, Column(Order = 2)]
        public int ProjectNo { get; set; }
        public Project Project { get; set; }
        public float Hours { get; set; }

    }
}
