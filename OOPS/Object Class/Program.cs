using System;

namespace Object_Class
{
    public class Program
    {
        static void Main()
        {
            try
            {
                Console.WriteLine("** Object Class Demo **\n");

                Object objectReference1 = new Object();

                if (objectReference1 == null)
                {
                    Console.WriteLine("Null Object");
                }
                else
                {
                    Object objectReference2 = new Object();

                    // Compare objectReference1 & objectReference2 (Different Objects)
                    Console.WriteLine("objectReference1.Equals(objectReference2): " + objectReference1.Equals(objectReference2));
                    Console.WriteLine("objectReference1 HashCode: " + objectReference1.GetHashCode());
                    Console.WriteLine("objectReference2 HashCode: " + objectReference2.GetHashCode());

                    // Assigning objectReference1 to objectReference2
                    objectReference1 = objectReference2;
                    Console.WriteLine("\nAfter assignment: objectReference1 = objectReference2");

                    Console.WriteLine("objectReference1.Equals(objectReference2): " + objectReference1.Equals(objectReference2));
                    Console.WriteLine("objectReference1 HashCode: " + objectReference1.GetHashCode());
                    Console.WriteLine("objectReference2 HashCode: " + objectReference2.GetHashCode());

                    // Example of boxing: Assigning an integer value to an object type
                    object o = 1999;
                    Console.WriteLine("\nBoxing Example:");
                    Console.WriteLine("o HashCode: " + o.GetHashCode());
                    Console.WriteLine("o.Equals(o): " + o.Equals(o));
                    Console.WriteLine("o.ToString(): " + o.ToString());
                    Console.WriteLine("o.GetType(): " + o.GetType());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("\nError: " + ex.Message);
            }
        }
    }
}
