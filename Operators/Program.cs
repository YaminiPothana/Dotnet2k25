using System;
using System.Runtime.Serialization;
using System.Security.Cryptography.X509Certificates;

namespace Operators
{
    class Operators
    {
        public int c = 10; // Global variable
        static  int D = 20;// Static variable
        public const float PI = 3.14f; //Constant Variable
        readonly int Age = 10; //readonly Variable
         
        public static void Main(string[] args)
        {
            Console.WriteLine(D);
            ++D;
            Console.WriteLine(D);
            D ++;
            Console.WriteLine(D);
            Operators operators = new Operators();
            Console.WriteLine(operators.Age);
            Console.WriteLine(operators.c);
            Console.WriteLine(PI);
            Console.WriteLine("sizeof(char)     :  " + sizeof(char));
            Console.WriteLine("sizeof(byte)     :  " + sizeof(byte));
            Console.WriteLine("sizeof(sbyte)    :  " + sizeof(sbyte));
            Console.WriteLine("sizeof(float)    :  " + sizeof(float));
            Console.WriteLine("sizeof(ushort)   :  " + sizeof(ushort));
            Console.WriteLine("sizeof(double)   :  " + sizeof(double));
            Console.WriteLine("sizeof(int)      :  " + sizeof(int));
            Console.WriteLine("sizeof(bool)     :  " + sizeof(bool));
            Console.WriteLine("sizeof(short)    :  " + sizeof(short));

        }
    }
}
