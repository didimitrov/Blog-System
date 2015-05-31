using BlogSys.Models;
using Microsoft.AspNet.Identity.EntityFramework;

namespace BlogSys.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection")
        {
        }
    }
}
