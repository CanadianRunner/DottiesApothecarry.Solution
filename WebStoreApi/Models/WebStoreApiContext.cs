using Microsoft.EntityFrameworkCore;

namespace WebStoreApi.Models
{
  public class WebStoreApiContext : DbContext
  {
    public WebStoreApiContext(DbContextOptions<WebStoreApiContext> options)
      : base(options)
      {
      }

      public DbSet<Item> Items { get; set; }
  }
}