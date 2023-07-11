using Microsoft.EntityFrameworkCore;
using SuperShop.Data.Entities;

namespace SuperShop.Data
{
    public class DataContext: DbContext
    {
        public DbSet<Product> Produts { get; set; }
        public DataContext(DbContextOptions<DataContext>options):base(options) 
        {

        }


    }
}
