using System;
 

namespace INHERITANCE
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
            Rectangle rectangle1 = new Rectangle();           
            rectangle1.AreaOfRectangle(20.34, 40.65);
            rectangle1.PerimeterOfRectangle(20.34,40.65);
            Rectangle.Print();
            Square.PrintResult();
            Figures figuresObj = new Square();
          // Figures figuresObj1 = new Figures();
            //figuresObj1.Display();
            figuresObj.Display();
            Square squareObj = new Square();
            squareObj.AreaOfSquare(10.76);
            squareObj.PerimeterOfSquare(10.76);
            Triangle triangle1 = new Triangle();
            triangle1.AreaOfTriangle(5.65,8.65);
            triangle1.PerimeterOfTriangle(5.65, 8.65,6.87);

        }
    }
    }
