using Microsoft.EntityFrameworkCore;

namespace MVCPractica1.Models {

        public class equiposDbContext : DbContext {

            public equiposDbContext(DbContextOptions options) : base(options) {

            }


            public DbSet<marcas> marcas { get; set; }

        }
    
}
