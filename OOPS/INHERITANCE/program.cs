using System;

namespace INHERITANCE
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("** Inheritance Project Demonstration **\n");

            Constants.DisplayMenu();
            string choice = Console.ReadLine() ?? "";

            switch (choice)
            {
                case "1":
                    Console.Write("Enter Length: ");
                    double length = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter Width: ");
                    double width = Convert.ToDouble(Console.ReadLine());

                    Rectangle rectangle = new Rectangle(length, width);
                    rectangle.CalculateArea();
                    rectangle.CalculatePerimeter();
                    Rectangle.Print();
                    break;

                case "2":
                    Console.Write("Enter Height: ");
                    double height = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter Base Width: ");
                    double baseWidth = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter Side A: ");
                    double sideA = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter Side B: ");
                    double sideB = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter Side C: ");
                    double sideC = Convert.ToDouble(Console.ReadLine());

                    Triangle triangle = new Triangle(height, baseWidth, sideA, sideB, sideC);
                    triangle.CalculateArea();
                    triangle.CalculatePermiter();
                    break;

                case "3":
                    Console.Write("Enter Side Length: ");
                    double squareLength = Convert.ToDouble(Console.ReadLine());

                    Square square = new Square(squareLength);
                    square.CalculateArea();
                    square.CalculatePerimeter();
                    Square.PrintResult();
                    break;

                case "4":
                    Console.Write("Enter Radius: ");
                    double radius = Convert.ToDouble(Console.ReadLine());

                    Circle circle = new Circle(radius);
                    circle.CalculateArea();
                    circle.CalculateCircumference();
                    break;

                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }
}
