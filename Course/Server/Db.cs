using Course.Shared;
using Microsoft.EntityFrameworkCore;

namespace Course.Server
{
    public class Db : DbContext

    {
        public Db(DbContextOptions<Db> options):base(options)
        { }
            
            
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Person>().HasKey(p => p.Id);
            modelBuilder.Entity<Person>().HasIndex(p => p.MobileNumber).IsUnique();
            modelBuilder.Entity<Teacher>().HasData(new[]
            {
                new Teacher { Id = -1 , MobileNumber="123" , Name = "Pero",Surname = "Peric" },
                 new Teacher { Id = -2 , MobileNumber="456" , Name = "Miko",Surname = "Mikic" },
                  new Teacher { Id = -3 , MobileNumber="789" , Name = "Lepi",Surname = "Lepic" },
            }); ;
            modelBuilder.Entity<Student>().HasData(new[]
           {
                new Student { Id = -4 , MobileNumber="112" , Name = "Neko",Surname = "Nekic" },
                 new Student { Id = -5 , MobileNumber="223" , Name = "Viko",Surname = "Vikic" },
                  new Student { Id = -6 , MobileNumber="334" , Name = "Depo",Surname = "Depic" },
            }); ;
        }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }

    }


}
