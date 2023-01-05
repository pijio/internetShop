using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace InternetShop.DAL
{
    public sealed class InternetShopDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductAdditInfo> ProductAdditInfos { get; set; }
        public DbSet<Characteristics> ProductsChararcteristics { get; set; }
        private IConfiguration _configuration;
        public InternetShopDbContext(DbContextOptions<InternetShopDbContext> options, IConfiguration configuration) : base(options)
        {           
            _configuration = configuration;
            Database.EnsureCreated();
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {            
            builder.ApplyConfigurationsFromAssembly(typeof(InternetShopDbContext).Assembly);
            base.OnModelCreating(builder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(_configuration.GetSection("ConnectionStrings")["PostgreSql"]);
        }
    }
}