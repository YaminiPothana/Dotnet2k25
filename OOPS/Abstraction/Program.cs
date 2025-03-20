using System;

namespace Abstraction
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter any one option below: \n 1. Hyundai \n 2. Toyota");
                string userInput = Console.ReadLine() ?? " ";
                if (string.IsNullOrEmpty(userInput))
                {
                    Console.WriteLine("Invalid option selected");
                    return;
                }

                switch (userInput.ToLower())
                {
                    case Constants.Hyundai:
                        Hyundai hyundaiCar = new Hyundai();
                        Console.WriteLine(hyundaiCar.CheckAC());
                        hyundaiCar.Wheel();
                        printCarInfo(Constants.Hyundai, hyundaiCar.EngineCylinder(), hyundaiCar.Price());
                        break;

                    case Constants.Toyota:
                        Toyota toyotaCar = new Toyota();
                        Console.WriteLine(toyotaCar.CheckAC());
                        toyotaCar.Wheel();
                        printCarInfo("Toyota", toyotaCar.EngineCylinder(), toyotaCar.Price());
                        break;

                    default:
                        Console.WriteLine("Invalid option selected");
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

        public static void printCarInfo(string carName, int numOfEngineCylinders, double price)
        {
            Console.WriteLine($"{carName} Engine Cylinder: {numOfEngineCylinders}");
            Console.WriteLine($"{carName} Price: {price}");
            Console.WriteLine("*******************************************");
        }
    }
}
