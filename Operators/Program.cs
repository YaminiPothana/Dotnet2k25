using System;

namespace OperatorsDemo
{
    class Program
    {
        // Static variable
        private static int _staticValue = 20;

        // Instance variables
        private readonly int _age;
        private const float Pi = 3.14f;
        private int _instanceValue = 10;

        // Constructor to initialize readonly variable
        public Program()
        {
            _age = 10;
        }

        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Initial Static Value: " + _staticValue);
                IncrementStaticValue();
                Console.WriteLine("Updated Static Value: " + _staticValue);

                // Creating object to access instance variables
                Program programInstance = new Program();

                Console.WriteLine("Readonly Age: " + programInstance._age);
                Console.WriteLine("Instance Variable: " + programInstance._instanceValue);
                Console.WriteLine("Constant PI Value: " + Pi);

                // Displaying size of data types
                DisplayDataTypeSizes();
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Execution completed.");
            }
        }

        // Method to increment static value
        private static void IncrementStaticValue()
        {
            _staticValue++;
        }

        // Method to display size of data types
        private static void DisplayDataTypeSizes()
        {
            try
            {
                Console.WriteLine("Size of char     : " + sizeof(char));
                Console.WriteLine("Size of byte     : " + sizeof(byte));
                Console.WriteLine("Size of sbyte    : " + sizeof(sbyte));
                Console.WriteLine("Size of float    : " + sizeof(float));
                Console.WriteLine("Size of ushort   : " + sizeof(ushort));
                Console.WriteLine("Size of double   : " + sizeof(double));
                Console.WriteLine("Size of int      : " + sizeof(int));
                Console.WriteLine("Size of bool     : " + sizeof(bool));
                Console.WriteLine("Size of short    : " + sizeof(short));
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error while fetching data type sizes: " + ex.Message);
            }
        }
    }
}
