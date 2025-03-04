using System;
namespace INHERITANCE
{
    public class Square :Figures
    {
        public static void PrintResult()
        {
            Console.WriteLine("Static method of child class");
        }
        public override void Display()
        {
            Console.WriteLine("overriding display method of child class");
        }
        public void AreaOfSquare(double length)
        {
            this.length = length;
            Console.WriteLine("Area of square is  :" + length * length);
        }
        public void PerimeterOfSquare(double length)
        {
            this.length = length;
            Console.WriteLine("Area of square is  :" + 4 * length);
        }
    }
}
