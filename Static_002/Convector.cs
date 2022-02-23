using System;

namespace Static_002
{
    static class Convector
    {
        private const double firstFormulaCosntant = 1.8;
        private const int secondFormulaCosntant = 32;
        public static double CelsiusToFahrenheit(string temperatureCelsius)
        {
            double tempCelsius = Convert.ToDouble(temperatureCelsius);
            return tempCelsius * firstFormulaCosntant + secondFormulaCosntant;
        }
        public static double FahrenheitToCelsius(string temperatureFahrenheit)
        {
            double tempFahrenheit = Convert.ToDouble(temperatureFahrenheit);
            return Math.Round((tempFahrenheit - secondFormulaCosntant) / firstFormulaCosntant, 2); 
        }
    }
}
