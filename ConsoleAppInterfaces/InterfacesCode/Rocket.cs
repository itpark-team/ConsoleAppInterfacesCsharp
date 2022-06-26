using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppInterfaces.InterfacesCode
{
    internal class Rocket : IFlyable
    {
        private int _p1, _p2;

        public Rocket(int p1, int p2)
        {
            _p1 = p1;
            _p2 = p2;
        }

        public void Fly()
        {
            Console.WriteLine($"Fly with Rocket {_p1} {_p2}");
        }
    }
}
