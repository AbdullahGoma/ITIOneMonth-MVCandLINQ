using System.ComponentModel.DataAnnotations;

namespace Sheet3.Models
{
    public class Entity<T>
    {
        [Key]
        public T SSN { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public bool IsVisable { get; set; }

    }
}
