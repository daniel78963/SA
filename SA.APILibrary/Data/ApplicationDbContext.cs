using Microsoft.EntityFrameworkCore;
using SA.APILibrary.Entities;

namespace SA.APILibrary.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Configuración de la relación uno a muchos entre Author y Book
            //modelBuilder.Entity<Book>()
            //    .HasOne(b => b.Author)
            //    .WithMany(a => a.Books)
            //    .HasForeignKey(b => b.AuthorId)
            //    .OnDelete(DeleteBehavior.Cascade); // Configura el comportamiento de eliminación en cascada

            //modelBuilder.Entity<Author>().Property(x => x.Name).IsRequired().HasMaxLength(150);
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
