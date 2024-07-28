using System.ComponentModel.DataAnnotations;

namespace ForYod.Model
{
    public class Employee
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = " חובה להכניס שם פרטי")]
        [StringLength(25, ErrorMessage = "שם יכול להכיל עד 25 תווים")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = " חובה להכניס שם משפחה")]
        [StringLength(40, ErrorMessage ="שם משפחה יכול להכיל עד 40 תווים")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "חובה לכלול מייל")]
        [EmailAddress(ErrorMessage = "מייל לא תקין")]

        [StringLength(255)]
        public string EmailAddress { get; set; }

        [Required]
        [StringLength(100)]
        public string Department { get; set; }
    }
}
