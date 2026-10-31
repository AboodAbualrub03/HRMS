using HRMS.Models;
using Microsoft.EntityFrameworkCore;

namespace HRMS.DbContexts
{
    public class HRMSContext:DbContext
    {
        public HRMSContext(DbContextOptions<HRMSContext> options):base(options)
        {

            //options contains 
            //SqlProvider : Sql Server , Oracle 
            //Connection String : 

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //modelBuilder.Entity<Employee>()
            //      .HasOne(x => x.Department)
            //      .WithMany()
            //      .HasForeignKey(x=>x.DepartmentId);

            // Seeding 
            modelBuilder.Entity<Lookup>().HasData(
                
                //Employee Posistions (Major Code)
                new Lookup {Id = 1 , MajorCode = 0,MinorCode =0 ,Name = "Employee Positions"},
                new Lookup {Id = 2 , MajorCode = 0,MinorCode =1 ,Name = "Manager"},
                new Lookup {Id = 3 , MajorCode = 0,MinorCode =2 ,Name = "Developer"},
                new Lookup {Id = 4 , MajorCode = 0,MinorCode =3 ,Name = "HR"},
               
                //Department Types (Major Code = 1) 

                new Lookup {Id = 5 , MajorCode = 1,MinorCode = 0 ,Name = "Department Types"},
                new Lookup {Id = 6 , MajorCode = 1,MinorCode =1,Name = "Finance"},
                new Lookup {Id = 7 , MajorCode = 1,MinorCode =2 ,Name = "Adminstrative"},
                new Lookup {Id = 8 , MajorCode = 1,MinorCode =3 ,Name = "Technical"}

               
                );

            // BCrypt.Net.BCrypt.HashPassword("Admin@123") = $2a$11$Dx9BCzZ2EOOtGddMK0GXsOZcwZ1N0r.FgXaz65w3VGuwn/Y8sjzt.

            modelBuilder.Entity<User>()
                .HasData(
                 new User { Id = 1,Username = "Admin",HashedPassword = "$2a$11$Dx9BCzZ2EOOtGddMK0GXsOZcwZ1N0r.FgXaz65w3VGuwn/Y8sjzt.", IsAdmin = true}

                );
        }
        
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }

        public DbSet<Lookup>Lookups { get; set; }

        public DbSet<User> Users { get; set; }
    }
}
