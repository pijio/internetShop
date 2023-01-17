using System.Reflection.PortableExecutable;
using InternetShop.DAL.DomainModels;
using Microsoft.EntityFrameworkCore;

namespace InternetShop.DAL
{
    public sealed class InternetShopDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductAdditInfo> ProductAdditInfos { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<ProductType> ProductTypes { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<ProductCharacteristic> ProductCharacteristics { get; set; }
        public DbSet<Characteristic> Characteristics { get; set; }
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
            builder.Entity<Category>().HasKey(k => new { k.Id });
            builder.Entity<ProductType>().HasKey(k => new { k.TypeId });            
            builder.Entity<Order>().HasKey(k => new { k.OrderId, k.ProductId });            
            builder.Entity<OrderDetail>().HasKey(k => new { k.Id });
            builder.Entity<Order>().HasOne(t => t.Product)
                .WithMany(p => p.Orders)
                .HasForeignKey(d => d.ProductId)
                .IsRequired();
            builder.Entity<Characteristic>().HasKey(k => new { k.Id });
            builder.Entity<ProductCharacteristic>().HasKey(k => new { k.ProductId, k.Characteristic });
            builder.Entity<ProductCharacteristic>()
                .HasOne(pc => pc.Product)
                .WithMany(p => p.ProductCharacteristics)
                .HasForeignKey(pc => pc.ProductId);
            builder.Entity<ProductCharacteristic>()
                .HasOne(pc => pc.Characteristic)
                .WithMany(c => c.ProductCharacteristics)
                .HasForeignKey(pc => pc.CharacteristicId);
        }

        private void MapIdentityColumns(ModelBuilder builder)
        {
            builder.Entity<Product>().Property(x => x.ProductId).ValueGeneratedOnAdd();
            builder.Entity<ProductAdditInfo>().Property(x => x.InfoId).ValueGeneratedOnAdd();
            builder.Entity<Category>().Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Entity<User>().Property(k =>  k.Id ).ValueGeneratedOnAdd();
            builder.Entity<ProductType>().Property(k =>  k.TypeId ).ValueGeneratedOnAdd();
            builder.Entity<Characteristic>().Property(k => k.Id).ValueGeneratedOnAdd();

        }
    }
}