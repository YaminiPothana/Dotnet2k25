
namespace INHERITANCE
{
    public class Access
    {
        private void Display1()
        {
            Console.WriteLine("Private Method");
        }

        internal void Display2()
        {
            Console.WriteLine("Internal Method");
        }

        protected void Display3()
        {
            Console.WriteLine("Protected Method");
        }

        protected internal void Display4()
        {
            Console.WriteLine("Protected internal Method");
        }

        public void Display5()
        {
            Console.WriteLine("Public Method");
        }

        public static void Main(string[] args)
        {
            Access access = new Access();
            access.Display1();
            access.Display2();  
            access.Display3();
            access.Display4();
            access.Display5();

        }
    }
}