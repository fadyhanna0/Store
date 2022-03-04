using Microsoft.AspNetCore.Identity;

namespace MVC_Project.Core.Models
{
    public class AppUser : IdentityUser
    {
        public string Name { get; set; }
        public string Phone { get; set; }

        public bool IsAgree { get; set; }
        public string Address { get; set; }
        //public string Address { get; set; }


    }
}
