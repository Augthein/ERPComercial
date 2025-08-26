using Microsoft.EntityFrameworkCore;
using Users.Models;

namespace ERPDBContext.Data
{
    public class ErpDbContext : DbContext{
        public ErpDbContext(DbContextOptions<ErpDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
    }
}