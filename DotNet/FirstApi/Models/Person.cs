using System.ComponentModel.DataAnnotations;

namespace FirstApi.Models
{
    
    public class Person
    {
        [Required]
        public string Aadhar { get; set; }

        [MaxLength(100)]
        public string Name { get; set; }

        [Range(10, 100)]

        public int Age { get; set; }

        [EmailAddress]
        public string Email { get; set; }
    }
    public class PersonOp
    {
        static List<Person> people = new List<Person>();
        public static List<Person> GetPeople()
        {
            if (people.Count == 0)
            {
                people.Add(new Person() { Aadhar = "123445566677", Age = 23, Email = "a@gmail.com", Name = "Harry" });
                people.Add(new Person() { Aadhar = "123445896677", Age = 27, Email = "b@gmail.com", Name = "Gary" });
                people.Add(new Person() { Aadhar = "1234455096677", Age = 33, Email = "c@gmail.com", Name = "Jerry" });
                people.Add(new Person() { Aadhar = "123445566677", Age = 22, Email = "d@gmail.com", Name = "Mary" });
            }
            return people;

        }

        public static Person Search(string pAadhar)
        {
            return GetPeople().Where(p => p.Aadhar == pAadhar).FirstOrDefault();
        }

        public static List<Person> Age(int start, int end)
        {
            return GetPeople().Where(a => a.Age > start && a.Age < end).ToList();
        }

        internal static void CreateNew(Person p)
        {
            GetPeople();
            people.Add(p);
        }

        public static bool Update(String pAadhar, Person UpdatePerson)
        {
            var found = GetPeople().Where(p => p.Aadhar == pAadhar).FirstOrDefault();
            if (found != null)
            {
                found.Email = UpdatePerson.Email;
                found.Age = UpdatePerson.Age;
                found.Name = UpdatePerson.Name;
                return true;
            }
           
            else
                throw new Exception("No such record");
        }

        public static bool Delete(string aadhar)
        {
            var found = GetPeople().Where(p=>p.Aadhar==aadhar).FirstOrDefault();
            if (found != null)
            {
                GetPeople().Remove(found);
                return true;
            }
            else
                throw new Exception("Record does not exist");
            
        }
    }

    

}


