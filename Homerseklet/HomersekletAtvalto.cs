using System;
using System.Collections.Generic;
using System.Text;

namespace Homerseklet
{
    internal class HomersekletAtvalto
    {
        public double celsius;
        public double ToFahrenheit()
        {
            return ((celsius * 9) / 5) + 32;
        }

        public static double CelsiusToFahrenheit(double kapott)
        {
            return ((kapott * 9) / 5) + 32;
        }

    }
}
