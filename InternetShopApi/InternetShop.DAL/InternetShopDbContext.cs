using Microsoft.EntityFrameworkCore;

namespace InternetShop.DAL
{
    public sealed class InternetShopDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductAdditInfo> ProductAdditInfos { get; set; }
        public DbSet<Characteristics> ProductsCharacteristics { get; set; }
        public DbSet<Category> Categories { get; set; }
        public InternetShopDbContext(DbContextOptions<InternetShopDbContext> options) : base(options)
        {
        }
        
        protected override void OnModelCreating(ModelBuilder builder)
        {
            MapKeys(builder);
            MapIdentityColumns(builder);
            base.OnModelCreating(builder);
        }
        
        private void MapKeys(ModelBuilder builder)
        {
            builder.Entity<Product>().HasKey(k => new { k.ProductId });
            builder.Entity<ProductAdditInfo>().HasKey(k => new { k.InfoId });
            builder.Entity<Characteristics>().HasKey(k => new { k.CharactId });
            builder.Entity<Category>().HasKey(k => new { k.Id });
        }

        private void MapIdentityColumns(ModelBuilder builder)
        {
            builder.Entity<Product>().Property(x => x.ProductId).ValueGeneratedOnAdd();
            builder.Entity<Characteristics>().Property(x => x.CharactId).ValueGeneratedOnAdd();
            builder.Entity<ProductAdditInfo>().Property(x => x.InfoId).ValueGeneratedOnAdd();
            builder.Entity<Category>().Property(x => x.Id).ValueGeneratedOnAdd();

        }
    }
}