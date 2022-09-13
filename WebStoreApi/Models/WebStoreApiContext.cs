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

      protected override void OnModelCreating(ModelBuilder builder)
      {
        builder.Entity<Item>()
          .HasData(
            new Item { ItemId = 1, Name = "Lavendar", Description = "Organic lavendar, sold by the pound" , Price = 5.00, InStockQty = 100 },
            new Item { ItemId = 2, Name = "Chamomile", Description = "Organic Chamomile, sold by the pound" , Price = 8.50, InStockQty = 45 },
            new Item { ItemId = 3, Name = "Sage Sticks", Description = "White Sage Smudge Sticks, packs of 4" , Price = 7.00, InStockQty = 35 },
            new Item { ItemId = 4, Name = "Glass Vial - 25ml", Description = "25ml glass vial, sold in cases of 10", Price = 30.00, InStockQty = 15 },
            new Item { ItemId = 5, Name = "Blood Letting Starter Pack", Description = "Tools used for blood letting, kit includes: 1 fleam, 1 thumb lancet, 4 cups, and live leaches ", Price = 300.00, InStockQty = 3 }
          );
      }
  }
}