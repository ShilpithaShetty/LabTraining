// See https://aka.ms/new-console-template for more information
using ShapeLib;

Circle s1 = new Circle();
s1.radius = 21;
Console.WriteLine(s1.Draw());
Console.WriteLine(s1.GetDetails());
Console.WriteLine(s1.CalculateArea());

Rectangle s2 = new Rectangle();
s2.Length = 40;
s2.Breadth = 20;
Console.WriteLine(s2.Draw());
Console.WriteLine(s2.GetDetails());
Console.WriteLine(s2.CalculateArea());
