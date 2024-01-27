using System.ComponentModel.DataAnnotations;

namespace Sheet3.Models
{
    public class Superssn
    {
        [Required, Key, MaxLength(10)]
        public int SSSN { get; set; }
    }
}
