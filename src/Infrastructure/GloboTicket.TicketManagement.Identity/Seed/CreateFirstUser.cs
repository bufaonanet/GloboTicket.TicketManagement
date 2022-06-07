using GloboTicket.TicketManagement.Identity.Models;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace GloboTicket.TicketManagement.Identity.Seed
{
    public static class UserCreator
    {
        public static async Task SeedAsync(UserManager<ApplicationUser> userManager)
        {
            var applicationUser = new ApplicationUser
            {
                FirstName = "Douglas",
                LastName = "Souto",
                UserName = "bufao",
                Email = "douglas.bufaonanet@outlook.com",
                EmailConfirmed = true
            };

            var user = await userManager.FindByEmailAsync(applicationUser.Email);
            if (user == null)
            {
                await userManager.CreateAsync(applicationUser, "Senh@123?");
            }
        }
    }
}
