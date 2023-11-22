using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace MYLAB
{       public class Student
    {
        [Key]
        public int Id { get; set; }
        public string SName { get; set; }
        public List<Course> Courses { get; set; }
    }
        public class Course
    {
        [Key]
        public int Id { get; set; }
        public string CName { get; set; }
        public List<Student> Students { get; set; }
    }
    public class Company
    {
        [Key]
        public int Id { get; set; }
        public Student Intern { get; set;}
    }
   
        public class TestDbContext : DbContext // mapping class which has so many funcs and we dont know which we can configure 
                                               // so by common sense we put over ride and space so web get list of functions whose logic can be changed
        {// since db cant under stand, dbset converts class to db understandable form

        public DbSet<Student> studentss { get; set; }
        public DbSet<Company> Companyss { get; set; }
        public DbSet<Course> Coursess{ get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB; Database=Labdb2; Trusted_Connection=true");
            }
        }
    
}