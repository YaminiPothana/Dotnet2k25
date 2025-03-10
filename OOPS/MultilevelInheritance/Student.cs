using System;
using System.Xml.Linq;

namespace MultilevelInheritance
{
    // Intermediate Class (Derived from College)
    public class Student : College
    {
        public string? TeacherName { get; set; }

        // Method to Set and Display Student Details
        public void StudentDetails(int id, string name, string teacherName)
        {
            Id = id;
            Name = name;
            TeacherName = teacherName;

            Console.WriteLine("\n--- Student Details ---");
            Console.WriteLine($"Student ID     : {Id}");
            Console.WriteLine($"Student Name   : {Name}");
            Console.WriteLine($"Teacher Name   : {TeacherName}");
        }
    }
}
