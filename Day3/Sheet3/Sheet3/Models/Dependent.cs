using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sheet3.Models
{
    public class Dependent
    {
        [Required]
        [Key]
        [Column(Order = 1)]
        public int ESSN { get; set; }
        [ForeignKey("ESSN")]
        public Employee Employee { get; set; }
        [Required]
        [MaxLength(20)]
        [Key]
        [Column(Order = 2)]
        public string Name { get; set; }
        [Required]
        public DateOnly BirthDate { get; set; }
        [Required]
        [MaxLength(20)]
        public string RelationShip { get; set; }
        [Required]
        public char Gender { get; set; }
    }
}
