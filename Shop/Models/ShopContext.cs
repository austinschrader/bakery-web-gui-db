using System.Diagnostics;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Shop.Models
{
  public class ShopContext : IdentityDbContext<ApplicationUser>
  {
    public DbSet<Engineer> Engineers { get; set; }
    public virtual DbSet<Machine> Machines { get; set; }

    public DbSet<MachineEngineer> MachineEngineer { get; set; }

    public ShopContext(DbContextOptions options) : base(options) { }
  }
}