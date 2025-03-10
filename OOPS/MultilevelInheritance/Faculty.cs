using System;
using System.Xml.Linq;

namespace MultilevelInheritance
{
    // Derived Class (Multilevel Inheritance - Faculty extends Student)
    public class Faculty : Student
    {
        public int Salary { get; set; }

        // Method to Display Faculty Details
        public void FacultyDetails()
        {
            Console.WriteLine("\n--- Faculty Details ---");
            Console.WriteLine($"Faculty ID     : {Id}");
            Console.WriteLine($"Faculty Name   : {Name}");
            Console.WriteLine($"Salary         : {Salary}");
        }
    }
}
