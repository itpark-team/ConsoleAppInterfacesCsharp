using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppInterfaces
{
    internal class SomeAnimal2 : IEatable
    {
        public void Eat()
        {
            Console.WriteLine("SomeAnimal Eat");
        }
    }
}
