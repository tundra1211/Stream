using Microsoft.EntityFrameworkCore;
using Stream.API.Domain.Models;

namespace StreamPractice.Persistence.Contexts
{
    public class AppDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Result> Results { get; set; }
        //Constructor passes database config
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
    
            builder.Entity<Student>().ToTable("Students");
            builder.Entity<Student>().HasKey(s => s.Id);
            builder.Entity<Student>().Property(s => s.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Entity<Student>().Property(s => s.Name).IsRequired().HasMaxLength(50);
            //Foreign Key on stdID
            builder.Entity<Student>().HasOne(s => s.Result).WithOne(s => s.Student).HasForeignKey<Result>(r => r.stdID);
            //Populate student list
           builder.Entity<Student>().HasData
            (
                new Student { Id = 100, Name = "John Doe" },
                new Student { Id = 101, Name = "David De Gea" },
                new Student { Id = 102, Name = "Harry Maguire" },
                new Student { Id = 103, Name = "Victor Lindelof" },
                new Student { Id = 104, Name = "Aaron Wan-Bissaka" },
                new Student { Id = 105, Name = "Anthony Martial" },
                new Student { Id = 106, Name = "Fred" },
                new Student { Id = 107, Name = "Nemanja Matic" } // Id set manually due to in-memory provider
               
            );

            builder.Entity<Result>().ToTable("Results");
            builder.Entity<Result>().HasKey(r => r.Id);
            builder.Entity<Result>().Property(r => r.Id).IsRequired().ValueGeneratedOnAdd();          
            builder.Entity<Result>().Property(r => r.score).IsRequired();

            
         
        }
    }
}