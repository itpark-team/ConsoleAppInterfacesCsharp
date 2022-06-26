using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppInterfaces.Sortirovka
{
    internal class AscComparator : IMyComparator
    {
        public bool Compare(int a, int b)
        {
            return b < a;
        }
    }
}
