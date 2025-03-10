using System;

namespace Object_Class
{
    class UsageOfMethod
    {
        static void Main()
        {
            try
            {
                Console.WriteLine("\n** Object.ReferenceEquals Demonstration **\n");

                object? o = null;
                object? p = null;
                object? q = new Object();

                // Checking if two null objects reference the same memory
                Console.WriteLine("Object.ReferenceEquals(o, p): " + Object.ReferenceEquals(o, p));

                // Assigning reference of q to p
                p = q;
                Console.WriteLine("After assignment: p = q");

                Console.WriteLine("Object.ReferenceEquals(p, q): " + Object.ReferenceEquals(p, q));
                Console.WriteLine("p HashCode: " + p.GetHashCode());
                Console.WriteLine("q HashCode: " + q.GetHashCode());

                Console.WriteLine("Object.ReferenceEquals(o, p): " + Object.ReferenceEquals(o, p));

                Console.WriteLine("q HashCode: " + q.GetHashCode());
            }
            catch (Exception ex)
            {
                Console.WriteLine("\nError: " + ex.Message);
            }
        }
    }
}
