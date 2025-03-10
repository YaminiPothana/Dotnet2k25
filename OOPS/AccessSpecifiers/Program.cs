using System;

namespace AccessSpecifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*----- Access Specifier Demo -----*");

            // Creating object of Base Class (Access)
            Access baseObj = new Access();
            baseObj.TestAccess();

            // Creating object of Derived Class (Access2)
            Access2 derivedObj = new Access2();
            derivedObj.TestDerivedAccess();
        }
    }
}
