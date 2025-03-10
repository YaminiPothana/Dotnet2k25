using System;

namespace INHERITANCE
{
    public static class Constants
    {
        public const double PI = 3.14159;

        public static readonly string[] ShapeOptions =
        {
            "Rectangle",
            "Triangle",
            "Square",
            "Circle"
        };

        public static void DisplayMenu()
        {
            Console.WriteLine("Select a shape to calculate:\n");

            for (int i = 0; i < ShapeOptions.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {ShapeOptions[i]}");
            }

            Console.Write("Enter your choice: ");
        }
    }
}
