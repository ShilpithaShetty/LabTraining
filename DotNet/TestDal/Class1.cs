using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestDal
{
    //Domain CLass
    #region Inheritnce
    public class Parent
    {// attribute, data annotation or decorator
        [Key]
        public int ParentKey { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        
        public bool IsActive { get; set; }
    }

    public class Child:Parent
    {
        [NotMapped] // now we cant decide datatype and discriminator will decide

        public int  ChildKey { get; set;}
        public DateTime BirthDate { get; set; }
        [Range(18,100)]
        public int Age { get; set; }

    }
    public class Child2 : Parent
    {
        public string hobbies { get; set; }

    }

    #endregion Inheritance
    #region one2one and one2many
    public class One
    {
        [Key]
        public int Id { get; set; }
        public string Value { get; set; }

    }
    public class ToOne
    {
        [Key]
        public int Id { get; set; }
        public One RelatedToOne{ get; set; }

    }

    public class ToMany1
    {
        [Key]
        public int Id { get; set; }
        // always many type class will have a list/array
        public List<One> ToManyOnes { get; set;}
    }
    #endregion one2one and one 2many
    //mapping layer
    public class Many
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public List<toMany2> toMany2s { get; set; }
    }

    public class toMany2
    {
        [Key]
        public int Id { get; set; }
        public List<Many> Manys { get; set; }

    }
    public class TestDbContext : DbContext // mapping class which has so many funcs and we dont know which we can configure 
        // so by common sense we put over ride and space so web get list of functions whose logic can be changed
    {// since db cant under stand, dbset converts class to db understandable form
        public DbSet<Parent> Parents { get; set; }
        public DbSet<Child> children { get; set; }
        public DbSet<Child2> children2 { get; set; }
        public DbSet<One> Ones { get; set; }
        public DbSet<ToOne> ToOnes { get; set; }
        public DbSet<ToMany1> toMany1s { get; set; }
        
        public DbSet<Many> Manys { get; set; }
        public DbSet<toMany2> toMany2s { get; set; }





        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB; Database=TestDb; Trusted_Connection=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Using fluent Api
            modelBuilder.Entity<Parent>().Property(p => p.ParentKey).UseIdentityColumn();
            modelBuilder.Entity<Parent>().HasOne <Child>();
            modelBuilder.Entity<One>().HasMany<Many>();
            modelBuilder.Entity<Parent>().HasOne<Parent>();
            modelBuilder.Entity<Parent>().Property(p => p.ParentKey).IsRequired();

        }
    }
}