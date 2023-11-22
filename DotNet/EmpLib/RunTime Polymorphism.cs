using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpLib
{
    public class Father : Talents
    {
        //permitting different logic in derived 
        public virtual string settle()
        {
            return "get a govt job";

        }
        public string GetMarried()
        {
            return " sabhya srujana sheela, sarva guna sampanna girl married";
        }
        public override string Drawing()
        {
            return " i draw potratits";
        }
        public override string WhatIsDating()
        {
            return "meet gf/bf";
        }
    }
    public class child:Father
    {
        public override string Drawing()
        {
            return "child draws";
        }
        public override string WhatIsDating()
        {
            return "child dates";
        }
        public override string settle()
        {
            string howToLive = "my life my rules";
            howToLive = $"{howToLive} and later :{base.settle()} ";
            
            return howToLive;
        }
        // encapsulation
        new public string getMarried() 
        {
            return " ba guru madve agu";
        }// function hiding 
    }

    public abstract class Talents
    {
        public abstract string WhatIsDating();
        public abstract string Drawing();

        public string getDetails()
        {
            return " my name is sheela";
        }
    }





}
