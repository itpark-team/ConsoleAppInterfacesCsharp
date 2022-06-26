using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppInterfaces.Polymorfizm
{
    internal class Dog : IAnimal
    {
        public void MakeSound()
        {
            Console.WriteLine("Bark");
        }

        public void D1() { }
    }
}
