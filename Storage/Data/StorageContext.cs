using Microsoft.EntityFrameworkCore;

namespace Storage.Data
{
    //     A DbContext instance represents a session with the database and can be used to
    //     query and save instances of your entities. DbContext is a combination of the
    //     Unit Of Work and Repository patterns.
    public class StorageContext : DbContext
    {
        public StorageContext(DbContextOptions<StorageContext> options)
            : base(options)
        {
        }

        public DbSet<Storage.Models.Product> Product { get; set; } = default!;
        //     A DbContext instance represents a session with the database and can be used to
       
    }
}
