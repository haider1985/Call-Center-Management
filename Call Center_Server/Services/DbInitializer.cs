using Call_Center_Server.Common;
using Call_Center_Server.Data;
using Call_Center_Server.Services.IServices;

using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Call_Center_Server.Services
{
    public class DbInitializer : IDbInitializer
    {
        private readonly UserManager<IdentityUser> userManager;
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly ApplicationDbContext db;

        public DbInitializer(UserManager<IdentityUser> userManager,
            RoleManager<IdentityRole> roleManager,
            ApplicationDbContext db)
        {
            this.userManager = userManager;
            this.roleManager = roleManager;
            this.db = db;
        }
        public void Initialize()
        {
            try
            {
                if (db.Database.GetPendingMigrations().Any())
                {
                    db.Database.Migrate();
                }
                if (!roleManager.RoleExistsAsync(StaticConstant.Role_Admin).GetAwaiter().GetResult())
                {
                    roleManager.CreateAsync(new IdentityRole(StaticConstant.Role_Admin)).GetAwaiter().GetResult();
                    IdentityUser adminUser = new()
                    {
                        UserName = StaticConstant.AdminUser_Email,
                        Email = StaticConstant.AdminUser_Email,
                        EmailConfirmed = StaticConstant.AdminUser_EmailConfirmed,
                    };

                    userManager.CreateAsync(adminUser, StaticConstant.AdminUser_Passwoard).GetAwaiter().GetResult();
                    userManager.AddToRoleAsync(adminUser, StaticConstant.Role_Admin).GetAwaiter().GetResult();
                }
                if (!roleManager.RoleExistsAsync(StaticConstant.Role_User).GetAwaiter().GetResult())
                {
                    roleManager.CreateAsync(new IdentityRole(StaticConstant.Role_User)).GetAwaiter().GetResult();
                }
                if (!roleManager.RoleExistsAsync(StaticConstant.Role_Viewer).GetAwaiter().GetResult())
                {
                    roleManager.CreateAsync(new IdentityRole(StaticConstant.Role_Viewer)).GetAwaiter().GetResult();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
