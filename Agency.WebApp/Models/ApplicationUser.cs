using Microsoft.AspNetCore.Identity;

namespace Agency.WebApp.Models
{
    public class ApplicationUser : IdentityUser {
        public string Surname { get; set; }
        public string Patronymic { get; set; }
        public string Organization { get; set; }
    }
}
