using System;

namespace Static_002
{
    static class Convector
    {
        public static double CelsiusToFahrenheit(string temperatureCelsius)
        {
            double tempCelsius = Convert.ToDouble(temperatureCelsius);
            return tempCelsius * 9 / 5 + 32;
        }
        public static double FahrenheitToCelsius(string temperatureFahrenheit)
        {
            double tempFahrenheit = Convert.ToDouble(temperatureFahrenheit);
            return (tempFahrenheit - 32) * 5 / 9; 
        }
    }
}
