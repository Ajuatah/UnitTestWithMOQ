using Microsoft.EntityFrameworkCore;
using UnitTestWithMOQ.API.Models;

namespace UnitTestWithMOQ.API.Data
{
    
    public class ApplicationDbContex : DbContext
    {
        protected readonly IConfiguration Configuration;

        public ApplicationDbContex(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
        }
        public DbSet<Product> Products { get; set; }
    }
}
