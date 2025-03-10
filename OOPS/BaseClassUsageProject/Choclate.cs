using System;

namespace BaseClassProject
{
    // Base class representing a generic Chocolate.
    public class Chocolate
    {
        public void Display()
        {
            Console.WriteLine("Displaying details of the project.");
        }

        // Virtual method that can be overridden in derived classes.
        
        public virtual void Show()
        {
            Console.WriteLine("Show method details of Chocolate class.");
        }
    }
}
