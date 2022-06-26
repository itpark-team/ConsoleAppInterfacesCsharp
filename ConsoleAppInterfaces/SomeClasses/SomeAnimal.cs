using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppInterfaces
{
    internal class SomeAnimal : IEatable, ISound
    {
        public void Eat()
        {
            Console.WriteLine("SomeAnimal Eat");
        }

        public void MakeSound()
        {
            Console.WriteLine("SomeAnimal MakeSound");
        }
    }
}
