using System;

namespace MultilevelInheritance
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("**      Multilevel Inheritance Demonstration       **\n");

            try
            {
                // Creating Faculty Object (Faculty inherits from Student, which inherits from College)
                Faculty faculty = new Faculty
                {
                    Id = 1,
                    Name = "Dr. Yamini",
                    CollegeAddress = "Hyderabad",
                    Salary = 12000
                };

                faculty.FacultyDetails(); // Display Faculty Details

                // Creating Student Object
                Student student = new Student();
                student.StudentDetails(2, "Sunny", "Dr. Yamini");

                // Creating College Object
                College college = new College
                {
                    Id = 100,
                    Name = "XYZ University",
                    CollegeAddress = "Bangalore"
                };

                Console.WriteLine("\n--- College Details ---");
                Console.WriteLine($"College ID    : {college.Id}");
                Console.WriteLine($"College Name  : {college.Name}");
                Console.WriteLine($"Address       : {college.CollegeAddress}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\nAn error occurred: {ex.Message}");
            }
        }
    }
}
