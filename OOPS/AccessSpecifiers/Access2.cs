using System;

namespace AccessSpecifiers
{
    public class Access2 : Access
    {
        public void TestDerivedAccess()
        {
            Console.WriteLine("\nTesting Access Specifiers Inside Derived Class:");

            // Display1(); Not accessable outside of the class.
            Display2();   
            Display3();    
            Display4();    
            Display5();    
        }
    }
}
