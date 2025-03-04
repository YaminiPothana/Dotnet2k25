
namespace INHERITANCE
{
    /// <summary>
    /// 
    /// </summary>
    public  class Figures
    {
        public double  length;
        public double width;
        public double height;
        public double radius;
        //public void name()
        //{
        //    Console.WriteLine("good morning ");
        //}

        public virtual void  Display()
        {
            Console.WriteLine("Display method Details Of Parent class");
        }
        
         
    }

}