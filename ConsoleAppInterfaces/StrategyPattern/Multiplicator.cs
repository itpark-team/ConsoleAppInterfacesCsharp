using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppInterfaces.StrategyPattern
{
    internal class Multiplicator : ICaclulable
    {
        public double Calculate(double a, double b)
        {
            return a * b;
        }
    }
}
