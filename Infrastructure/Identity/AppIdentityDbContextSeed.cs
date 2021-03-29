using System.Linq;
using System.Threading.Tasks;
using Core.Entities.Identity;
using Microsoft.AspNetCore.Identity;

namespace Infrastructure.Identity
{
    public class AppIdentityDbContextSeed
    {
        public static async Task SeedUsersAsync(UserManager<AppUser> userManager)
        {
            if (!userManager.Users.Any())
            {
                var user = new AppUser
                {
                    DisplayName = "Mohit",
                    Email = "mohit@test.com",
                    UserName = "mohit@test.com",
                    Address = new Address
                    {
                        FirstName = "Mohit",
                        LastName = "Acharya",
                        Street = "test street",
                        City = "Test city",
                        State = "Test state",
                        ZipCode = "410057"
                    }
                };
                await userManager.CreateAsync(user, "Pa$$w0rd");
            }
        }
    }
}