using System.ComponentModel.DataAnnotations;

namespace Messenger.Models
{
    public class RegisterModel
    {
        [Required]
        public string Name { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Passwords are different")]
        public string ConfirmPassword { get; set; }
    }
}