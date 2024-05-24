using Microsoft.AspNetCore.Identity;

namespace Final_Project
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}


