using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Sheet3.Models
{
    public class WorksFor
    {
        [Required]
        [Key]
        [Column(Order = 1)]
        public int ESSN { get; set; }
        [ForeignKey("ESSN")]
        public Employee Employee { get; set; }
        [Required]
        [Key]
        [Column(Order = 2)]
        public int Pno { get; set; }
        [ForeignKey("Pno")]
        public Project Project { get; set; }
        [MaxLength(10)]
        public float Hours { get; set; }

    }
}
