// See https://aka.ms/new-console-template for more information
using EmpLib;

Person Rohit = new Person();
Rohit.Name = "ROHIT";
Console.WriteLine(Rohit.Eat());

Person leka=new Person();
leka.Name = "leka";
Console.WriteLine($"leka ests: {leka.Work()}");

//base=new derived();
Person sri = new Employee() { Designation="analyst",DOJ=DateTime.Now.AddMonths(-1) };
sri.Name = "sricharan";
((Employee)sri).Designation = "AD";
Console.WriteLine(sri.Eat());
Console.WriteLine(sri.Work());
Console.WriteLine($"empid for {sri.Name} is {((Employee)sri).EmpId}");
((Employee)sri).AttendTraining("c2c");

//polymorphism
Father nagsFather = new Father();
Console.WriteLine($"nags father :{nagsFather.settle()}");
Console.WriteLine($"nags father got married :{nagsFather.GetMarried()}");
Console.WriteLine($"nags father drawing conceptnof  drawing using abs- {nagsFather.Drawing()}");
Console.WriteLine($"nags father drawing conceptnof  dating using abs- {nagsFather.WhatIsDating()}");
//usinf virtual , modification are allowed using override
//over riddrn behaviour is executed
Father nags = new child();
Console.WriteLine($"nags  :{nags.settle()}");
Console.WriteLine($"nags got married :{nags.GetMarried()}");
Console.WriteLine($"nags  drawing conceptnof  drawing using abs- {nags.Drawing()}");
Console.WriteLine($"nags  drawing conceptnof  dating using abs- {nags.WhatIsDating()}");

//no virtual, modification dissalowed by base class, forced modification using new keyword
// forced execution using type casting {((child)nags2).getMarried()
Father nags2 =new child();
Console.WriteLine($"nags 2 get married {((child)nags2).getMarried()}");

//SEE OVERLOADING- COMPILE-TIME POLYMORPHISM BELOW
Employee vidya = new Employee();
vidya.Name = "vidyasagar";
vidya.Designation = "ceo";
Console.WriteLine(vidya.Work("solving bugs"));
Console.WriteLine(vidya.Work());
// usage of protected
// exposing non -public informati0on through public methods
Employee srikar2 = new Employee();
srikar2.setTaxInfo(" im20% tax payer");
Console.WriteLine(srikar2.getTaxInfo());

Person sricharan = new Person("261071191916","9945501556");
Console.WriteLine($"sri adhar is: {sricharan.Aadhar}  | sri mon is : {sricharan.MobileNumber}");

Employee praj = new Employee("123456","9663756500");
Console.WriteLine($"praj adhar is: {praj.Aadhar}  | parj mon is : {praj.MobileNumber}");
// objects go to heap/class memory bcoz they dont know how much space they need
// in case of static memory we know how much space it need hence it goes to stack memory
// and stcak memory is small so we use gc- garbage colector
// dead objects or small objects
//very large objects / calm objects / unmanaged objects that clr cant manage

Console.WriteLine($"{EmpUtils.EmpCount}");

//adding employees to a temporary db using - static
EmpUtils.EmpDb.Add(srikar2);
EmpUtils.EmpDb.Add(praj);
EmpUtils.EmpDb.Add(vidya);

EmpUtils.EmpDb.Add(new Employee("aababa", "93737383"){ Name = "sru", Designation = "tax",
    salary=3443434 });
EmpUtils.EmpDb.Add(new Employee("aabafa", "9373738333")
{
    Name = "siri",
    Designation = "tax tech",
    salary = 34345553
});
EmpUtils.EmpDb.Add(new Employee("aagrbaba", "9323737383")
{
    Name = "lavanya",
    Designation = "taaax",
    salary = 34332234
});
// queirs in dotnet
// get all employees whose aadhar  starts with aa
// get all employees with salary greater than 6lk
// where retuens list

//var resultlist1= EmpUtils.EmpDb.Where((emp) => emp.Aadhar!=null && emp.Aadhar.StartsWith("aa"));
//resultlist.ToList().ForEach(emp =>Console.WriteLine($"{emp.Name}|{emp.Aadhar}"));
//get all employees with salary greater than 6lk

var resultlist2 = EmpUtils.EmpDb.Where((emp) => emp.salary > 60000);
resultlist2.ToList().ForEach((emp) =>Console.WriteLine($"{emp.Name}|{emp.salary}"));
