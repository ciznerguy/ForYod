using System.ComponentModel.DataAnnotations;

namespace ForYod.Model
{
    public class Employee
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [StringLength(100)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(100)]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        [StringLength(255)]
        public string EmailAddress { get; set; }

        [Required]
        [StringLength(100)]
        public string Department { get; set; }
    }
}
