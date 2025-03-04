using System;
 

namespace MultilevelInheritance
{
    public class Student:College
    {
        string tName;
        public void StudentDetails(int id,string name)
        {
            this.id = id;
            this.name = name;
            Console.WriteLine("The id of student is :" + id );
            Console.WriteLine("The name of student is :" + name );

        }
    }
}


































