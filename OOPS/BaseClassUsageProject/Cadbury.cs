using System;

namespace BaseClassProject
{
    public class Cadbury : Chocolate
    {
        
        public void DisplayCadburyDetails()
        {
            Console.WriteLine("Showing details of the Cadbury class.");
        }

        public override void Show()
        {
            Console.WriteLine("Overriding the Show method in Cadbury class.");
        }

        // Calls the base class Show method.
        public void CallBaseShowMethod()
        {
            base.Show();
        }
    }
}
