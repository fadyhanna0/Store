using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace MVC_Project.Core.Models
{
    public class RegistrationVM
    {
        [Required(ErrorMessage = "This Field Required")]
        [EmailAddress(ErrorMessage = "Invalid Mail Address")]
        public string Email { get; set; }



        [Required]
        [MinLength(6, ErrorMessage = "Min. length of Password is 6 characters")]
        public string Password { get; set; }

        [Required]
        [MinLength(6, ErrorMessage = "Min. length of Password is 6 characters")]
        [Compare("Password", ErrorMessage = "Password not Matched")]
        public string ConfirmPassword { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        
        //[RegularExpression(@"^01[0-2]\d{1,8}$",ErrorMessage ="Enter valid Phone Number")]
        public string Phone { get; set; }
        public bool IsAgree { get; set; }
    }
}
