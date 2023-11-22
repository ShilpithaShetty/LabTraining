using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpLib
{
    public enum Gender
    {
        Male, Female
    }
    public class Person

    {
        public Person()
        {
            
            
        }

        public Person(string aadhar)
        {
            this.Aadhar = aadhar;   
        }
        // her firstd right side this is called thatis base  class is executed 1st
        public Person( string pAadhar, string pMobile):this( pAadhar)
        {
            this.MobileNumber= pMobile;
        }

        public string Name { get; set; }
        public string Aadhar { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }

        public string MobileNumber { get; set; }
        public DateTime DOB { get; set; }

        public string Eat()
        {
            return $"{this.Name}eats lunch, dinner";

        }
        public string Sleep()
        {
            return $"{this.Name}sleeps 8 hrs";

        }
        public virtual string Work()
        {
            return $"{this.Name}works for 4 hrs";
        }
        protected string TaxDetails { get; set; }
    }
}
