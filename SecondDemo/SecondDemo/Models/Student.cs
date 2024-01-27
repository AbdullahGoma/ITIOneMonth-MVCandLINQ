using System.ComponentModel.DataAnnotations;

namespace SecondDemo.Models
{
    public class Student
    {
        //Data Annotations
        [Required(ErrorMessage = "You must add student code")]
        public int Code { get; set; }
        [MaxLength(15)]
        public string Name { get; set; }
        [EmailAddress]
        [Required]
        public string Email { get; set; }
        [Range(12, 18)]
        public int Age { get; set; }

    }
}
