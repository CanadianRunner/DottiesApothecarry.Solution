// using Microsoft.EntityFrameworkCore;
// using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

// namespace DottiesApothecarry.Models
// {
//   public class DottiesApothecaryContext : IdentityDbContext<ApplicationUser>
//   {
//     public DbSet<Item> Item { get; set; }
//     public DbSet<User> User { get; set; }
//     public DbSet<ItemUser> ItemUser { get; set; }

//     public BakeryContext(DbContextOptions options) : base(options) { }

//     protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//     {
//       optionsBuilder.UseLazyLoadingProxies();
//     }
//   }
// }