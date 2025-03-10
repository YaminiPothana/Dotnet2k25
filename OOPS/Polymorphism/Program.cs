using System;

namespace PolymorphismExample
{
   
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("** Method Overloading Example (Polymorphism) **\n");

            try
            {
                MultipleAdds additionObj = new MultipleAdds();

                // Calling overloaded methods inside try block
                additionObj.Addition(45, 34, 67);
                additionObj.Addition(23, 34);
                additionObj.Addition(5, 4, 6);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            }
        }
    }
}
