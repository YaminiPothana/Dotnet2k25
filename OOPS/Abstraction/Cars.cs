using System;

namespace Abstraction
{
    public abstract class Cars
    {
        // Wheel method should not be redefined in derived classes
        public void Wheel()
        {
            Console.WriteLine("The car has 4 wheels.");
        }

        public string CheckAC()
        {
            return "AC is available";
        }

        public abstract double Price();
        public abstract int EngineCylinder();
    }
}
