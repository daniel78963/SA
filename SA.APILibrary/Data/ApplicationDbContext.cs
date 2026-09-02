using Microsoft.EntityFrameworkCore;
using SA.APILibrary.Entities;

namespace SA.APILibrary.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        protected ApplicationDbContext()
        {
        }

        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books  { get; set; }
        //Add-Migration TableBooks
        //Update-Database
    }
}
