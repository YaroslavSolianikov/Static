using System;

namespace Static_002
{
    static class Convector
    {
        public static double CelsiusToFahrenheit(string temperatureCelsius)
        {
            double tempCelsius = Convert.ToDouble(temperatureCelsius);
            return tempCelsius * 1.8 + 32;
        }
        public static double FahrenheitToCelsius(string temperatureFahrenheit)
        {
            double tempFahrenheit = Convert.ToDouble(temperatureFahrenheit);
            return Math.Round((tempFahrenheit - 32) / 1.8 , 2); 
        }
    }
}
