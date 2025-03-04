 

namespace INHERITANCE
{
    public class Rectangle : Figures
    {
        //Method to create area of Rectangle
        public static void Print()
        {
            Console.WriteLine(" Static Method Of rectangle class ");
        }
        public void AreaOfRectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
            Console.WriteLine("Area of rectangle is  :" + length * width);
        }

        public void PerimeterOfRectangle(double length,double width)
        {
            this.length = length;
            this.width = width;
            Console.WriteLine("Perimeter of rectangle is  :" + 2 * (length * width));
        }
         
    }
}

