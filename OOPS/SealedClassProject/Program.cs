
namespace SealedClassProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            AdminDept adminDeptObj = new AdminDept();
            adminDeptObj.AdminDetails();
            int i = 5;
            int result = i.Factorial();
            Console.WriteLine( result);


        }

    }
}