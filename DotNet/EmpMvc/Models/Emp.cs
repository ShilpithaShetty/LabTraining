using System.ComponentModel.DataAnnotations;

namespace EmpMvc.Models
{
    public class Emp
    {

        [MaxLength(100)]
        public string Name { get; set; }

        [Range(10, 100)]

        public int Age { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public int EmpId { get; set; }

        [Required]
        public string Designation { get; set; }

        [Required]
        public double Salary { get; set; }

        [Required]
        public DateTime DOJ { get; set; }
    }

    public class EmpOp
    {
        static List<Emp>_emp = new List<Emp>();
        public static List<Emp> GetEmp()
        {
            if (_emp.Count == 0)
            {
                _emp.Add(new Emp() {Age = 23, Email = "a@gmail.com", Name = "Haley", EmpId = 123, Designation="Analyst", Salary= 2000000, DOJ = Convert.ToDateTime("10-10-2022") });
                _emp.Add(new Emp() {Age = 27, Email = "b@gmail.com", Name = "Barry", EmpId = 456, Designation="Consultant", Salary= 2700000, DOJ = Convert.ToDateTime("10-01-2023") });
                _emp.Add(new Emp() {Age = 33, Email = "c@gmail.com", Name = "Jerry", EmpId = 789, Designation= "Exec Manager", Salary = 4000000, DOJ = Convert.ToDateTime("10-07-2020") });
                _emp.Add(new Emp() {Age = 22, Email = "d@gmail.com", Name = "Kendal", EmpId = 012,Designation = "Analyst", Salary = 2000000, DOJ = Convert.ToDateTime("10-10-2023") });
            }
            return _emp;

        }

        public static void CreateNew(Emp e)
        {
            _emp.Add(e);
        }

        public static Emp Search(int empid)
        {
            return GetEmp().Where(e => e.EmpId == empid).FirstOrDefault();
        }
    }
}
