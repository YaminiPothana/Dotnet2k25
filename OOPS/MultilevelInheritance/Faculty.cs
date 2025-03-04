using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultilevelInheritance
{
    public class Faculty :Student
    {
        public int salary;
        public void FacultyDetails()
        {
            Console.WriteLine("The id of faculty is :" + id);
            Console.WriteLine("The name of faculty is :" + name);
            Console.WriteLine("The Salary of faculty is :" +salary);

        }
    }
}
