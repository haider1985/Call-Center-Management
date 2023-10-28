using Call_Center_Server.Models;

using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Call_Center_Server.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<CallModel> Calls { get; set; }
        public DbSet<AssignedCallModel> AssignedCallModels { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
    }
}