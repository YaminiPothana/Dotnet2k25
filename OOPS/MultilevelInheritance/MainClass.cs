using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultilevelInheritance
{
    public  class MainClass
    {
        public static void Main(string[] args)
        { 
            Faculty faculty1 = new Faculty();
            faculty1.StuDetails(1,"Yamini");
            faculty1.salary = 12000;
            Student student1 = new Student();
            student1.Caddress ="Hyderabad";
            College college1 = new College();
            college1 = student1;
            college1.tName = "Sunny";
        }
    }
}
