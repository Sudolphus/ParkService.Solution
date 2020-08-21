using Microsoft.EntityFrameworkCore;

namespace ParkService.Models
{
  public class ParkContext : DbContext
  {
    public ParkContext(DbContextOptions<ParkContext> options)
    {
    }

    public DbSet<Park> Parks { get; set; }

  }
}