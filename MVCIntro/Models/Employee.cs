using System.ComponentModel.DataAnnotations;

namespace MVCIntro.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Fullname")]
        [StringLength(20)]
        public string Name { get; set; }

        [Display(Name = "Salary in dollars")]
        [Range(5, 100)]
        public int Salary { get; set; }
        public string Department { get; set; }
    }
}
