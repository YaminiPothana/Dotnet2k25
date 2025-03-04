public class ObjectClassDemo
{
    static void Main()
    {
        Object objectReference1 = new Object();
       // objectReference1 = null;
        if (objectReference1 == null)
        {
            Console.WriteLine("NUll Object");
        }
        else
        {
            Object objectReference2 = new Object();
            Console.WriteLine(objectReference1.Equals(objectReference2));
            Console.WriteLine(objectReference1.GetHashCode());
            Console.WriteLine(objectReference2.GetHashCode());
            objectReference1 = objectReference2;
            Console.WriteLine(objectReference1.Equals(objectReference2));
            Console.WriteLine(objectReference1.GetHashCode());
            Console.WriteLine(objectReference2.GetHashCode());
            object o = new object();
            o = 1999;
            Console.WriteLine(o.GetHashCode());

            Console.WriteLine(o.Equals(o));
            Console.WriteLine(o.ToString());
            o.GetType();
        }
    }
}
