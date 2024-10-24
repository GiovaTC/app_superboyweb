using app_superboyweb.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace app_superboyweb.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // Define tus DbSets para las tablas de la base de datos
        public DbSet<Identity> Identities { get; set; }
    }
}
