using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppInterfaces.InterfacesCode
{
    internal class Plane : IFlyable
    {
        private int _p1;

        public Plane(int p1)
        {
            _p1 = p1;
        }

        public void Fly()
        {
            Console.WriteLine($"Fly with Plane {_p1}");
        }
    }
}
