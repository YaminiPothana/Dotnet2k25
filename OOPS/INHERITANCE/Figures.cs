using System;

namespace INHERITANCE
{
    public abstract class Figures
    {
        protected double Length;
        protected double Width;
        protected double Height;
        protected double Radius;

        // Abstract methods that must be overridden where necessary
        public abstract void CalculateArea();

        // Virtual method that can be overridden if required
        public virtual void CalculatePerimeter()
        {
            Console.WriteLine("Perimeter calculation is not applicable for this shape.");
        }
    }
}
