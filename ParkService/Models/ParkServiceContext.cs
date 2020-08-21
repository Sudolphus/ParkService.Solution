using Microsoft.EntityFrameworkCore;

namespace ParkService.Models
{
  public class ParkContext : DbContext
  {
    public ParkContext(DbContextOptions<ParkContext> options) : base(options)
    {
    }

    public DbSet<Park> Parks { get; set; }
    public DbSet<User> Users { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Park>()
        .HasData(
          new Park { ParkId = 1, Name = "Crater Lake", State = "Oregon" },
          new Park { ParkId = 2, Name = "Yoakam Point", State = "Oregon" },
          new Park { ParkId = 3, Name = "Long Beach", State = "Washington" },
          new Park { ParkId = 4, Name = "Big Bend", State = "Texas" },
          new Park { ParkId = 5, Name = "Death Valley", State = "California" },
          new Park { ParkId = 6, Name = "Everglade", State = "Florida" },
          new Park { ParkId = 7, Name = "Gateway Arch", State = "Missouri" },
          new Park { ParkId = 8, Name = "Glacier Park", State = "Montana" },
          new Park { ParkId = 9, Name = "Grand Teton", State = "Arizona" },
          new Park { ParkId = 10, Name = "Great Basin", State = "Nevada" },
          new Park { ParkId = 11, Name = "Great Smoky Mountains", State = "North Carolina" },
          new Park { ParkId = 12, Name = "Volcano Park", State = "Hawaii" },
          new Park { ParkId = 13, Name = "Isla Royale", State = "Michigan" },
          new Park { ParkId = 14, Name = "Joshua Tree", State = "California" },
          new Park { ParkId = 15, Name = "Kobuk Valley", State = "Alaska" },
          new Park { ParkId = 16, Name = "Mammoth Cave", State = "Kentucky" },
          new Park { ParkId = 17, Name = "Mesa Verde", State = "Colorado" },
          new Park { ParkId = 18, Name = "Mount Rainier", State = "Washington" },
          new Park { ParkId = 19, Name = "Petrified Forest", State = "Arizona" },
          new Park { ParkId = 20, Name = "Pinnacles", State = "California" },
          new Park { ParkId = 21, Name = "Theodore Roosevelt Park", State = "North Dakota" },
          new Park { ParkId = 22, Name = "Voyageurs", State = "Minnesota" },
          new Park { ParkId = 23, Name = "White Sands", State = "New Mexico" },
          new Park { ParkId = 24, Name = "Wind Cave", State = "South Dakota" },
          new Park { ParkId = 25, Name = "Yellowstone", State = "Wyoming" },
          new Park { ParkId = 26, Name = "Yosemite", State = "California" },
          new Park { ParkId = 27, Name = "Zion", State = "Utah" }
        );
    }
  }
}