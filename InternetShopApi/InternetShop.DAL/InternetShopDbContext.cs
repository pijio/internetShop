using Microsoft.EntityFrameworkCore;

namespace InternetShop.DAL
{
    public class InternetShopDbContext : DbContext
    {
        public InternetShopDbContext(DbContextOptions<InternetShopDbContext> options) : base(options)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(typeof(InternetShopDbContext).Assembly);
        }
    }
}