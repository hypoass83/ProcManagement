
using Domain.Entities.Examination;
using Domain.Entities.Security;
using Microsoft.EntityFrameworkCore;


namespace Infrastructure.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
       : base(options)
        { }

        //security
        public DbSet<Employe> Employe { get; set; }
        //examination
        public DbSet<Exam> Exam { get; set; }
        public DbSet <Examcentre> Examcentre { get; set; }
        public DbSet<AcomCentre> AcomCentre { get; set; }
        public DbSet<Division> Division { get; set; }
        public DbSet<Subjects> Subjects { get; set; }
        public DbSet<Subjects> SubSubjects { get; set; }
        public DbSet<Specialty> Specialty { get; set; }
        public DbSet<SpecSubject> SpecSubject { get; set; }
        
        //candidateData
        public DbSet<Candidate> Candidate { get; set; }
        public DbSet<CandSubjects> CandSubjects { get; set; }
        public DbSet<RegValidation> RegValidation { get; set; }
        
    }


}

