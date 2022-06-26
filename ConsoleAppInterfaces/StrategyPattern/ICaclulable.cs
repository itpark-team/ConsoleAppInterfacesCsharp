using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppInterfaces.StrategyPattern
{
    internal interface ICaclulable
    {
        double Calculate(double a, double b);
    }
}
