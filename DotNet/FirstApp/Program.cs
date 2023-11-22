// See https://aka.ms/new-console-template for more information
using System.Diagnostics;

void meth()
{
    Console.WriteLine("Hello, World!");
    int num1 = 100;
    int num2 = 100;
    Console.WriteLine("sum=" + (num1 + num2));

    //alternative declaration
    var num3 = 200;
    var formattedfloat = 200f;
    var formatteddouble = 200d;
    var formatteddecimal = 200m;

    Console.WriteLine(num3.GetType().Name);
    Console.WriteLine(formattedfloat.GetType().Name);
    Console.WriteLine(formatteddouble.GetType().Name);
    Console.WriteLine(formatteddecimal.GetType().Name);
    Console.WriteLine($"the data tupe of formattedfloat is{formattedfloat.GetType().Name}");
    Console.WriteLine($"the data tupe of num3 is{num3.GetType().Name}");

    bool isEverything = false;
    string gm = "hello";
    char isSingle = 'S';

    Console.WriteLine($"value of {nameof(isEverything)}is{isEverything}");
}
//meth();
void ConversionOfTypes()
{
    int num1 = 100;
    double num2 = 100;
    bool isEverythingOk = true;
    string str = "hello";
    string strnum = "100";

    var result1 = (double)num1;
    var result2 = (int)num2;
    // var results3=(string)isEverythingOk;// string on heap & bool on stack. hence error in casting

    var convert1 = Convert.ToString(num1);
    var convert2 = Convert.ToInt32(strnum);
    //var constant3= Convert.ToInt32(str); //error at runtime
}
//ConversionOfTypes();

void WorkingWithArrays()
{
    int[] arr = new int[3];
    arr[0] = 1;
    arr[1] = 2;
    arr[2] = 3;

    for(int i=0;i<arr.Length; i++)
    {
        Console.WriteLine($"value={arr[i]}");
    }

    string[] greetings = { "namaste", "hello", "hola" };

    int counter = 0;
    while(counter<greetings.Length-1)
    {Console.WriteLine($"a new way to greet:{greetings[counter]}");
        counter++;

    }
    int[] evens = {2,4,6,8,10 };
    counter = 0;
    do
    {
        Console.WriteLine($"the next even number:{evens[counter]}");
        counter++;
    } while (counter <= evens.Length-1);
    object[] objArray = { 100, "ok", new[] { 1, 2, 3 } };

    foreach (var singleitem in objArray)
    {
        if (singleitem.GetType().Name == "Int32[]")
        {
            foreach (var item in (Int32[])singleitem){
                Console.WriteLine(item);
            }

        }
        else
        {
            Console.WriteLine($"simple item is{nameof(objArray)}:{singleitem}");
        }


    }
}

//WorkingWithArrays();

void workingwithlists()
{
    List<String> shoppinglist = new List<String>();
    Console.WriteLine($"total items{shoppinglist.Count}");
    shoppinglist.Add("bags");
    log(new object[] { "item addded:", shoppinglist[0] });
    shoppinglist.Add("dress");
    log(new object[] { "item addded:", shoppinglist[1] });
    shoppinglist.Remove("bags");
    log(new object[] { "item removed","SHOES"});
    shoppinglist.Add("dress");
    printvalues(shoppinglist);
    //Console.WriteLine($"total item in shopping bag:{shoppinglist.Count}");

    Print(new object[] {"comma seperated values of the shopping list ", shoppinglist[0],
    shoppinglist[1],
    "\n the total count of items is:",
    shoppinglist.Count()});


    
}

//11-01-2023:12:18:00.0 :total count of items added is 3
//void log(object[] pvalues)  next line is generic
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


void printvalues<T>(List<T> pcollection)
{
    foreach (var item in pcollection)
    {
        Console.WriteLine(item);
    }


}
//void Print(object[] pvalues) next line generic
void Print<T>(T[] pvalues)
{
    string result = "";
    foreach (var item in pvalues)
    {
        result = $"{result},{item}";
    }
    result = result.TrimStart(',');
    Console.WriteLine(result);

}
workingwithlists();

