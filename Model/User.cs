using System.ComponentModel.DataAnnotations;

namespace ForYod.Model
{
    public class User
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [StringLength(100)]
        public string FullName { get; set; }

        [Required]
        [EmailAddress]
        [StringLength(255)]
        public string Email { get; set; }

        [Required]
        [StringLength(100)]
        public string Password { get; set; }
    }
}
