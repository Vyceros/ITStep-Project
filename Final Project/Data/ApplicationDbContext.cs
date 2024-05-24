using Microsoft.EntityFrameworkCore;
using Final_Project.Models.Hotel;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Final_Project.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Hotels> Hotels { get; set; }
        public DbSet<Rooms> Rooms { get; set; }
        public DbSet<RoomType> RoomType { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<ApplicationUser> User { get; set; }
    }
}