using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppInterfaces.Polymorfizm
{
    internal class Cat : IAnimal
    {
        public void MakeSound()
        {
            Console.WriteLine("Meow");
        }

        public void C1() { }
    }
}
