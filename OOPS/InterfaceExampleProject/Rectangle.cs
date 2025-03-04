using System;
namespace InterfaceExampleProject
{
    class Rectangle : IPolygon
    {
       // implementation of methods inside interface
        public void CalculateArea(int length, int breadth)
        { 
                int area = length * breadth;
                Console.WriteLine("Area of Rectangle: " + area);
        }
        public void CalculatePrmter(int length, int breadth) 
        { 
            int perimeter = 2*(length + breadth);
            Console.WriteLine(perimeter);
        }
    }
}

