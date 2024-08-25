using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Talabat.core.Entities.Identity;
using Talabat.Repository.Data;

namespace Talabat.Repository.Identity
{
    public class AppIdentityContextSeed
    {
        public static async Task SeedUser(ILoggerFactory Ilogger, UserManager<AppUser> userManager)
        {
            try
            {
                if (userManager.Users.Any() == false)
                {
                    var user = new AppUser()
                    {
                        DisplayName = "Mahmoud",
                        Email = "Houda@Houda.com",
                        UserName = "Houda123"
                    };
                   await userManager.CreateAsync(user, "Houda2020");
                }
            }
            catch (Exception ex)
            {
                var logger = Ilogger.CreateLogger<StoreContextSeed>();
                logger.LogError(ex.Message);
            }
        }
    }
}
