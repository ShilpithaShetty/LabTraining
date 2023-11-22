// See https://aka.ms/new-console-template for more information
//declaration = new data type
using System;

class Progarm
{
    delegate void Compute(int n1, int n2);// why 
    delegate void Contractor(double budget);   // we cant declare delegate inside a func
    //coz its like a data type and variablke int x=10 which becomes local variable if we decl;are inside func
    static void Main()
    {
        Action<String, bool> Work = new Action<String, bool>((mystr,boool) => 
        Console.WriteLine($"string is: {mystr}, bool is -{boool}"));

        Func<string,string,string> Print = (s1,s2) => $"s2 is {s2}";

        Predicate<string> UpdateDb = (inpt) =>
        {
            Console.WriteLine("this is update");
            return true;
        };
        //Work("hello", true);
        //Console.WriteLine( Print("hi", "hello"));
       Console.WriteLine( UpdateDb("hiii"));
    }

    private static void UsingGenericDelegate()
    {
        Action<double> RRM = new Action<double>((budget) =>
        {
            Console.WriteLine($"reg charges :{budget * 95 / 100}");
            Console.WriteLine($"recep charge: {budget * 5 / 100}");
        });

        Func<int, int, String> modifieCompute = (n1, n2) => $"add is {n1 + n2}";
        modifieCompute += (n1, n2) => $"sub : {n1 - n2}";

        Predicate<int> isActive = (v) =>
        {
            if (v == 0) return false;
            else return true;
        };
        //invoke all thde delegates
        RRM(5000d);
        Console.WriteLine(modifieCompute(200, 100));
        // since it can only retrn 1 value, it returns output of 
        //last function and all other funcs will be executed
        Console.WriteLine($"outpur of Predicate: {isActive(1)}");
    }

    private static void MarriageDelegate()
    {
        Contractor marriage = new Contractor((b) => Console.WriteLine($"pandit charge{b * 20 / 100}"));
        marriage += (b) => Console.WriteLine($"catering {b * 50 / 100}");
        marriage += (b) => Console.WriteLine($"mandap decoration{b * 5 / 100}");
        marriage += (b) => Console.WriteLine($"Couple arrive in car: {b * 15 / 100}");
        //invoke marriage delagate like func
        marriage(50000);
    }

    private static void UsingLambdas()
    {
        // instanatiation
        Compute objShortCompute = new Compute((a, b) => Console.WriteLine($"add is {a + b}"));
        objShortCompute += (s, t) => Console.WriteLine($"s,t minus is{s - t}");
        objShortCompute += (s, t) => Console.WriteLine($"s,t mul is{s * t}");
        objShortCompute += (s, t) => Console.WriteLine($"s,t div is{s / t}");

        // invocation like  calling a func
        objShortCompute(250, 20);
    }

    private static void Delegates_withLongcut()
    {
        // instantiate
        Compute objCompute = new Compute(AddFn);
        objCompute += SubFn;
        objCompute += MulFn;
        objCompute += DivFn;
        objCompute(100, 200);
    }

    static void AddFn(int n1, int n2)
    {
        Console.WriteLine($"sum ois {n1 + n2}");
    }



    static void SubFn(int n1, int n2)
    {
        Console.WriteLine($"sub ois {n2 - n1}");
    }



    static void MulFn(int n1, int n2)
    {
        Console.WriteLine($"Mul ois {n1 * n2}");
    }



    static void DivFn(int n1, int n2)
    {
        Console.WriteLine($"div ois {n2/n1}");
    }
}