using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmpDal
{
    public class Person
    {
        [Key]
        [StringLength(50)]
        public string Name { get; set; }
        [Range(10, 110)]
        public int Age { get; set; }
        public string Aadhar { get; set; }
        [StringLength(70)]
        public string Email { get; set; }
        [StringLength(120)]
        public string Address { get; set; }
        public string MobileNumber { get; set; }
        public DateTime DOB { get; set; }

    }

    public class Employee
    {
        [Key]
        public int EmpId { get; set; }
        [Required]
        [StringLength(50)]
        public string EmpName { get; set; }
        public string Designation { get; set; }
        public double Salary { get; set; }
        public DateTime DOJ { get; set; }
        public bool IsActive { get; set; }

    }

    public class EmpDbContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Person> People { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=EmployeeDb;Trusted_Connection=true");
        }
    }
}