using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DottiesApothecary.Models
{
    public class DottiesApothecaryContext : IdentityDbContext<ApplicationUser>
    {
    public DottiesApothecaryContext(DbContextOptions options) : base(options) { }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseLazyLoadingProxies();
    }
  }
}

// An error occurred while accessing the Microsoft.Extensions.Hosting services. Continuing without the application service provider. Error: 'AddDbContext' was called with configuration, but the context type 'DottiesApothecaryContext' only declares a parameterless constructor. This means that the configuration passed to 'AddDbContext' will never be used. If configuration is passed to 'AddDbContext', then 'DottiesApothecaryContext' should declare a constructor that accepts a DbContextOptions<DottiesApothecaryContext> and must pass it to the base constructor for DbContext.

// warn: Microsoft.EntityFrameworkCore.Infrastructure[10410]
      // 'AddEntityFramework' was called on the service provider, but 'UseInternalServiceProvider' wasn't called in the DbContext options configuration. Consider removing the 'AddEntityFramework' call, as in most cases it's not needed and may cause conflicts with other products and services registered in the same service provider.