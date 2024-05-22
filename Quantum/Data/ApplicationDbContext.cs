using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Quantum.Data
{

    //IdentityDbContext
    public class ApplicationDbContext : DbContext
    {

   

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Quantum.Models.Event> Events { get; set; }//= default!;

       // public DbSet<>

    }
}
