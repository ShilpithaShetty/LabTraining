// See https://aka.ms/new-console-template for more information
using System.Diagnostics;
using System.Diagnostics.Contracts;
using System.Reflection.Metadata.Ecma335;

partial class Del
{

    

    static void Main()
    {
        Action<string, bool> Work = new Action<string, bool>((desig, isActive) =>

        {
            Console.WriteLine($"Employee Designation: {desig}");
            Console.WriteLine($"Is the Employee currently working with the company? {isActive}");
        });

        Func<string, string, string> Print = (s, s1) => $"{s}";
        Predicate<string> isActive = (v) =>
        {
            if (v == "Yes") return true;
            else return false;
        };
        Work("Analyst", true);
        Print("Print this","Print this");
        Console.WriteLine($"UpdateDb is set as: {isActive("true")}");




    }
}