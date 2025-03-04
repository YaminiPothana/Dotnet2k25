using System;
 

namespace Abstraction
{
    public abstract class Cars
    {
        public void Wheel()
        {
            Console.WriteLine("hello");
        }
         
        public string CheckAC()
        {
            return "AC is available";
        }
        public abstract double Price();
        public abstract int  EngineCylinder();
        
    }
}
