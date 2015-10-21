using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrialByFire
{
    public class TemperatureConverter
    {
        public double ToCelcius(double f)
        {
            double c = 5.0 / 9.0 * (f - 32);
            return c;
        }

        public double ToFahrenheit(double c)
        {
            double f = c * (9.0 / 5.0) + 32;
            return f;
        }
    }
}
