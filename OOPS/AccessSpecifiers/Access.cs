using System;

namespace AccessSpecifiers
{
    public class Access
    {
        //In this class, scope of all the variables will be known.
        // Private Method - Accessible only within this class
        private void Display1()
        {
            Console.WriteLine("Private Method - Not accessible outside this class.");
        }

        // Internal Method - Accessible within the same assembly
        internal void Display2()
        {
            Console.WriteLine("Internal Method - Accessible within the same project.");
        }

        // Protected Method - Accessible in derived classes only
        protected void Display3()
        {
            Console.WriteLine("Protected Method - Accessible in derived classes.");
        }

        // Protected Internal Method - Accessible within same assembly & derived classes
        protected internal void Display4()
        {
            Console.WriteLine("Protected Internal Method - Accessible within assembly and derived classes.");
        }

        // Public Method - Accessible anywhere
        public void Display5()
        {
            Console.WriteLine("Public Method - Accessible from anywhere.");
        }

        // Method to test access within the same class
        public void TestAccess()
        {
            Console.WriteLine("\nTesting Access Specifiers Within Base Class:");
            Display1(); // Accessible inside this class
            Display2();
            Display3();
            Display4();
            Display5();
        }
    }
}
