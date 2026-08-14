using HireNova.Api.Constants;
using Microsoft.AspNetCore.Identity;

namespace HireNova.Api.Data
{
    internal static class RoleSeeder
    {
        public static async Task SeedAsync(RoleManager<IdentityRole<Guid>> roleManager)
        {
            string[] roles = [Roles.SuperAdmin, Roles.OrganisationAdmin,Roles.Recruiter,Roles.Candidate];
            foreach (var role in roles)
            {
                if (!await roleManager.RoleExistsAsync(role))
                {
                    await roleManager.CreateAsync(new IdentityRole<Guid>(role));
                }
            }
        }
    }
}
