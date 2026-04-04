
using Domain.Entities.Security;
using Microsoft.EntityFrameworkCore;


namespace Infrastructure.Context
{
    public class FsContext : DbContext
    {
        public FsContext(DbContextOptions<FsContext> options)
       : base(options)
        { }


        public DbSet<Employe> Employe { get; set; }

    }


}

