using System;

namespace Abstraction
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            { 

                Console.WriteLine("Enter any one options below: \n 1. Hyundai \n 2. Toyota");
                string userInput=Console.ReadLine() ?? " ";
                if (string.IsNullOrEmpty(userInput))
                {
                    Console.WriteLine(Constants.InvalidOption);
                    return;
                }

                switch (userInput.ToLower())
                {
                    case "hyundai":
                        Hyundai hyundaiCar = new Hyundai();
                        Console.WriteLine(hyundaiCar.CheckAC());
                        hyundaiCar.Wheel();
                        Console.WriteLine("Hyundai Engine Cylinder: " + hyundaiCar.EngineCylinder());
                        Console.WriteLine("Hyundai Price: " + hyundaiCar.Price());

                        Console.WriteLine("*******************************************");
                        break;

                    case "toyota":
                        Toyota toyotaCar = new Toyota();
                        Console.WriteLine(toyotaCar.CheckAC());
                        toyotaCar.Wheel();
                        Console.WriteLine("Toyota Engine Cylinder: " + toyotaCar.EngineCylinder());
                        Console.WriteLine("Toyota Price: " + toyotaCar.Price());
                        break;

                    default:
                        Console.WriteLine(Constants.InvalidOption);
                        return;
                }
               
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Execution completed.");
            }
        }
    }
}
