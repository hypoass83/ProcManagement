
using Domain.Entities.Security;
using Microsoft.EntityFrameworkCore;


namespace Infrastructure.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
       : base(options)
        { }


        public DbSet<Employe> Employe { get; set; }

    }


}

