using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace AppointmentScheduling.Models
{
    public class ApplicationUser:IdentityUser
    {
        public string Name { get; set; }
    }
}
