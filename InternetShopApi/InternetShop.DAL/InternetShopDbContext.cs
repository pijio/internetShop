using Microsoft.EntityFrameworkCore;

namespace InternetShop.DAL
{
    public sealed class InternetShopDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductAdditInfo> ProductAdditInfos { get; set; }
        public DbSet<Characteristics> ProductsCharacteristics { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<ProductType> ProductTypes { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
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
            builder.Entity<User>().HasKey(k => new { k.Id });
            builder.Entity<Product>().HasKey(k => new { k.ProductId });
            builder.Entity<ProductAdditInfo>().HasKey(k => new { k.InfoId });
            builder.Entity<Characteristics>().HasKey(k => new { k.CharactId });
            builder.Entity<Category>().HasKey(k => new { k.Id });
            builder.Entity<ProductType>().HasKey(k => new { k.TypeId });            
            builder.Entity<Order>().HasKey(k => new { k.OrderId, k.ProductId });            
            builder.Entity<OrderDetail>().HasKey(k => new { k.Id });
            builder.Entity<Order>().HasOne(t => t.Product).WithMany(p => p.Orders).HasForeignKey(d => d.ProductId)
                .IsRequired();
        }

        private void MapIdentityColumns(ModelBuilder builder)
        {
            builder.Entity<Product>().Property(x => x.ProductId).ValueGeneratedOnAdd();
            builder.Entity<Characteristics>().Property(x => x.CharactId).ValueGeneratedOnAdd();
            builder.Entity<ProductAdditInfo>().Property(x => x.InfoId).ValueGeneratedOnAdd();
            builder.Entity<Category>().Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Entity<User>().Property(k =>  k.Id ).ValueGeneratedOnAdd();
            builder.Entity<ProductType>().Property(k =>  k.TypeId ).ValueGeneratedOnAdd();


        }
    }
}