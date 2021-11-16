using hotelRes_V_03.Data.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;

namespace hotelRes_V_03.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();
                if (!context.Guest_Profiles.Any())
                {
                    context.Guest_Profiles.AddRange(new Guest_Profile()
                    {
                        Guest_name = "data",
                        Guest_contact="3456878",
                        Guest_email="data@gmail.com"
                    }, new Guest_Profile()
                    {
                        Guest_name = "test",
                        Guest_contact = "93456878",
                        Guest_email = "test@gmail.com"
                    }
                 ) ;
              

                    context.SaveChanges();
                }
            }
        }


    }
}
