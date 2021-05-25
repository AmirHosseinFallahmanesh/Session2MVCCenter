using Microsoft.EntityFrameworkCore;

namespace Part1
{
    public class SampleContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer("Server=.;Database=DemoSession2;Trusted_Connection=True;");
        }
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
    }
}
