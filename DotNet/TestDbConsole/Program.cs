// See https://aka.ms/new-console-template for more information

using TestDal;
using TestDbConsole;

Console.WriteLine("hello, world");

TestDbContext dbContext = new TestDbContext();
if (true)// we can use false so that we cant further update or add recordes to table
{
    dbContext.Parents.Add(new Parent() { Name = "Varun", IsActive = true });
    dbContext.SaveChanges();
}

///Update record Vidya to something else
///
if (false)
{
    var tobeupdated = dbContext.Parents
      .ToList()
      .Where(p => p.Name == "Seema")
      .FirstOrDefault();
    tobeupdated.Name = "Zero to Hero";
    dbContext.SaveChanges();
}
//Delete records

var tobedeleted = dbContext.Parents
                   .ToList()
                   .Where((p) => p.Name == "Greg")
                   .FirstOrDefault();//we use this because when there are sames names then the first one will be deleted ot updated
if (tobedeleted != null)
{
    dbContext.Parents.Remove(tobedeleted);
    dbContext.SaveChanges();
}
else
{
    Console.WriteLine($"***Data  is already deleted***");
}

//Get Records

crudf<Parent>.Get().ForEach((p) =>
{
    if (p.IsActive == true)
        Console.WriteLine($"{p.Name} is a {p.IsActive} parent");
    else
        Console.WriteLine($"{p.Name} is child");
});