using System;
 

namespace INHERITANCE
{
    internal class Triangle : Figures
    {
        public void AreaOfTriangle(double height, double width)
        {
            this.height = height;
            this.width = width;
            Console.WriteLine("Area of Triangle is :" + (0.5) * height * width);
        }
        public void PerimeterOfTriangle(double height, double width,double length)
        {
            this.height = height;
            this.width = width;
            this.length = length;
            Console.WriteLine("Perimeter of Triangle is :" + length + height + width);
        }
        
    }
}
