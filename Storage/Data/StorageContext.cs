using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Storage.Models;

namespace Storage.Data
{
    //     A DbContext instance represents a session with the database and can be used to
    //     query and save instances of your entities. DbContext is a combination of the
    //     Unit Of Work and Repository patterns.
    public class StorageContext : DbContext
    {
        public StorageContext (DbContextOptions<StorageContext> options)
            : base(options)
        {
        }

        public DbSet<Storage.Models.Product> Product { get; set; } = default!;
    }
}
