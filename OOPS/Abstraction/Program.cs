
using Abstraction;

public  class Vehicles
{
    public static void Main(string[] args)
    {
        Hyundai hyundaiCar = new Hyundai();
        hyundaiCar.CheckAC();
        hyundaiCar.Wheel();
        Console.WriteLine(hyundaiCar.EngineCylinder());
        Toyota toyotaCar = new Toyota();
        toyotaCar.CheckAC();
        toyotaCar.Wheel();




    }


}