using CrudApps.Model;
using Microsoft.EntityFrameworkCore;

namespace CrudApps.Data
{
    public class BookDbContext : DbContext
    {
        public BookDbContext(DbContextOptions<BookDbContext> options) : base(options)
        {
        }

        public DbSet<Book> Books { get; set; }
    }

}
