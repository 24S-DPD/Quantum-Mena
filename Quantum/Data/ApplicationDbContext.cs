using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Quantum.Data
{

    //IdentityDbContext
    public class ApplicationDbContext : DbContext
    {

   

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }



        public DbSet<Quantum.Models.Event> DbSet_Events { get; set; }//= default!;
        

        //*> Maja 
        public DbSet<Quantum.Models.User> DbSet_Users { get; set; }//= default!;





        // public DbSet<>

    }
}
