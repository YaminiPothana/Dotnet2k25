using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    public class Toyota : Cars
    {
        public override int EngineCylinder()
        {
            return 6;
        }

        public override double Price()
        {
            return 38874.7896;
        }
        public void Wheel()
        {
            Console.WriteLine("Yamini");
        }
    }
}
