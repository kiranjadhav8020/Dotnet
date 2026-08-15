using CurdOperation_RestAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace CurdOperation_RestAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

       public DbSet<Student> Students { get; set; }
    }
}
