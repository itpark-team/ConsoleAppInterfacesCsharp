using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppInterfaces.StrategyPattern
{
    internal class MathMachine
    {
        private double _a, _b;

        private ICaclulable _calculator;

        public MathMachine(double a, double b, ICaclulable calculator)
        {
            _a = a;
            _b = b;
            _calculator = calculator;
        }

        public void SetCalculator(ICaclulable calculator)
        {
            _calculator = calculator;
        }

        public double DoMath()
        {
            return _calculator.Calculate(_a, _b);
        }


    }
}
