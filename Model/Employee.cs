using System.ComponentModel.DataAnnotations;

namespace ForYod.Model
{
    public class Employee
    {
        [Key]
        public int ID { get; set; }

<<<<<<< HEAD
        [Required(ErrorMessage = " חובה להכניס שם פרטי")]
        [StringLength(25, ErrorMessage = "שם יכול להכיל עד 25 תווים")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = " חובה להכניס שם משפחה")]
        [StringLength(40, ErrorMessage ="שם משפחה יכול להכיל עד 40 תווים")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "חובה לכלול מייל")]
        [EmailAddress(ErrorMessage = "מייל לא תקין")]

=======
        [Required]
        [StringLength(100)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(100)]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
>>>>>>> 230d044b6afcb745ab8d418295da8c43078c0935
        [StringLength(255)]
        public string EmailAddress { get; set; }

        [Required]
        [StringLength(100)]
        public string Department { get; set; }
    }
}
