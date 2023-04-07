using BookBulk.Models;
using Microsoft.EntityFrameworkCore;

namespace BookBulk.DataAccess
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {
        }

        public DbSet<Category> Categories { get; set; }
    }
}
