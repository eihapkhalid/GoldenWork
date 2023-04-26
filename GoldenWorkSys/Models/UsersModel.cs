using System.ComponentModel.DataAnnotations;
namespace GoldenWorkSys.Models
{
    public class UsersModel
    {
        [Required(ErrorMessage = "plz enter employee FirstName")]
        [StringLength(100, ErrorMessage = "FirstName must be less than 100")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "plz LastName employee name")]
        [StringLength(100, ErrorMessage = "LastName must be less than 100")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "plz enter employee Email")]
        [StringLength(100, ErrorMessage = "Email must be less than 100")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter a password.")]
        [MinLength(8, ErrorMessage = "Password must be at least 8 characters long.")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$", ErrorMessage = "Password must contain at least one uppercase letter, one lowercase letter, one number, and one special character.")]
        public string Password { get; set; }
    }
}
