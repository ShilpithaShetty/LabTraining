using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestDal;

namespace TestDbConsole
{
    public class crudf<T> where T : Parent
    {
        static TestDbContext dbContext = new TestDbContext();
        public static void Add(string pNmae, bool pIsActive)
        {
            dbContext.Parents.Add(new Parent() { Name = pNmae, IsActive = pIsActive });
            dbContext.SaveChanges();
        }

        public static void Update(string pName, string pUpdatedValue)
        {
            var tobeupdated = dbContext.Parents
           .ToList()
           .Where((p) => p.Name == pName)
           .FirstOrDefault();

            tobeupdated.Name = pUpdatedValue;
            dbContext.SaveChanges();
        }

        public static List<T> Get()
        {

            dbContext.Parents
                     .ToList()
                     .ForEach((p) =>
                     {
                         if (p.IsActive == true)
                             Console.WriteLine($"{p.Name} is an {p.IsActive} parent");
                         else
                             Console.WriteLine($"{p.Name} is child");
                     });
            return dbContext.Parents.ToList() as List<T>;

        }




        public static T SearchOne(string pName)
        {
            var result = dbContext.Parents
                .ToList()
                .Where(p => p.Name == pName)
                .FirstOrDefault();
            return result as T;
        }
        public static void Delete(string pName)
        {
            var tobedeleted = dbContext.Parents
        .ToList()
        .Where((p) => p.Name == pName)
        .FirstOrDefault();
            dbContext.Parents.Remove(tobedeleted);
            dbContext.SaveChanges();
        }
    }
}
