using System.ComponentModel.DataAnnotations;

namespace WiredBrainCoffee.Models
{
    public class Contact
    {
        [Required]
        public string Name { get; set; }
        [Phone]
        [Required]
        public string Phone { get; set; }
        [EmailAddress]
        [Required]
        public string Email { get; set; }
        [MinLength(10)]
        [Required]
        public string Message { get; set; }
    }
}
