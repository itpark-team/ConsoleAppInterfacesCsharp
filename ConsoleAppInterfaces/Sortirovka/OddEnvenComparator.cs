using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppInterfaces.Sortirovka
{
    internal class OddEnvenComparator : IMyComparator
    {

        public bool Compare(int a, int b)
        {
            return a % 2 == 0 && b % 2 != 0;
        }
    }
}
