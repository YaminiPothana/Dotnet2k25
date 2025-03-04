using System;
 
namespace Object_Class
{
    class UsageOfMethod
    {
        static void Main()
        {
            object o = null;
            object p = null; 
            object q = new Object();
            Console.WriteLine(Object.ReferenceEquals(o, p));
           // Console.WriteLine(o.GetHashCode());
            p = q;
            Console.WriteLine(Object.ReferenceEquals(p, q));
            Console.WriteLine(p.GetHashCode());
            Console.WriteLine(q.GetHashCode());
            Console.WriteLine(Object.ReferenceEquals(o, p));
            //Console.WriteLine(o.GetHashCode());
            Console.WriteLine(q.GetHashCode());


        }


    }
}
