// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Car Maruti = new Car(new SuzukiEngine(new Cylinder(new Piston(), new CrankShaft(new Transmitter()))));
Car Toyota = new Car(new ToyotaEngine());
class Car {
    public Car (EngineVendor suzuki)
    {

    }

}

interface EngineVendor 
{

}

class SuzukiEngine : EngineVendor
{
    public SuzukiEngine(Cylinder cylinder)
    {
       
    }
}

class ToyotaEngine : EngineVendor
{

}

class Piston 
{
    
}

class Transmitter { }

class CrankShaft 
{
    public CrankShaft(Transmitter transmitter)
    {
            
    }
}

class Cylinder 
{
    public Cylinder(Piston piston, CrankShaft shaft)
    {

    }
}