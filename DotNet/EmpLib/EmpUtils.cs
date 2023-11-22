using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpLib
{
    public class EmpUtils
    {
        public static List<Employee> EmpDb { get; set; } = new List<Employee>();
        public static int EmpCount {  get; set; }
        void log<T>(T[] pvalues)

        {
            string result = "";
            foreach (var item in pvalues)
            {
                result = $"{result}{item}";
            }
            var finalresult = $"[{DateTime.Now.ToString()}]:{result}";
            //console logi ng

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("----");
            Console.WriteLine(finalresult);
            Debug.WriteLine("----------LoG---------");
            Debug.WriteLine(finalresult);
        }


    }
}
