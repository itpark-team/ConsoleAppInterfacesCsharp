using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppInterfaces.Composition
{
    internal class Worker
    {
        private string name;

        public Worker(string name)
        {
            this.name = name;
        }

        public void Work()
        {
            Console.WriteLine($"Im {name} working now");
        }

    }
}
