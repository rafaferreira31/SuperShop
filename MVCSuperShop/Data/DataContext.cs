using Microsoft.EntityFrameworkCore;
using MVCSuperShop.Data.Entities;

namespace MVCSuperShop.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
    }
}
