using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_002
{
    static class Convector
    {
        public static void CelsiusToFahrenheit(string temperatureCelsius)
        {
            double tempCelsius = Convert.ToDouble(temperatureCelsius);

            double tempFahrenheit = tempCelsius * 9 / 5 + 32;
            Console.WriteLine($"{tempCelsius} Degrees Celsuius = {tempFahrenheit} Degrees Fahrenheit ");
        }
        public static void FahrenheitToCelsius(string temperatureFahrenheit)
        {
            double tempFahrenheit = Convert.ToDouble(temperatureFahrenheit);

            double tempCelsius = (tempFahrenheit - 32) * 5/9;
            Console.WriteLine($"{tempFahrenheit} Degrees Fahrenheit = {tempCelsius} Degrees Celsuius ");
        }
    }
}
