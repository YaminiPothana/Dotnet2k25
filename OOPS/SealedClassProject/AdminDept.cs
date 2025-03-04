using System;

namespace SealedClassProject
{
    public sealed class AdminDept
    {
        public void AdminDetails()
        {
            Console.WriteLine("Admin Deparmnet Sealed Class");
        }
    }

    public static  class Student
    {
        public static void Extension(this AdminDept number)
        {
            Console.WriteLine("Extension Method");            
        }
    }
    static class demo 
    {
        public static int Factorial(this Int32 number)
        {
            if (number == 0)
            {
                return 1;
            }
            else if (number == 1)
            {
                return 1;
            }
            else 
            { 
                return number * Factorial(number -1);  
            }
        }
    }
}
