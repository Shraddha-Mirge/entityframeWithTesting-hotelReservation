using hotelRes_V_03.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace hotelRes_V_03.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Guest_Profile> Guest_Profiles { get; set; } 

        public DbSet<Hotel_Detail> hotel_Details { get; set; }
    }
}
