using System;

namespace BaseClassProject
{
    public class Britannia
    {
        public static void Main()
        {
            Console.WriteLine("* Base Class Usage Demo *\n");

            // Creating an object of the derived class (Cadbury)
            Cadbury cadburyObj = new Cadbury();

            // Calling overridden Show method
            cadburyObj.Show();

            // Calling method specific to Cadbury
            cadburyObj.DisplayCadburyDetails();

            // Calling base class Show method using base reference
            cadburyObj.CallBaseShowMethod();
        }
    }
}
