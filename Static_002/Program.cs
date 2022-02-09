using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_002
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose-1(Celsius to Fahrenheit) or 2-(Fahrenheit to Celsius)");
            int choice = int.Parse(Console.ReadLine());
            if(choice == 1)
            {
                Console.WriteLine("Enter degrees in Celsius");
                string temperatureCelsius = Console.ReadLine();
                Convector.CelsiusToFahrenheit(temperatureCelsius);
            }
            else if (choice == 2)
            {
                Console.WriteLine("Enter degrees in Fahrenheit");
                string temperatureFahrenheit = Console.ReadLine();
                Convector.FahrenheitToCelsius(temperatureFahrenheit);
            }
            else
                Console.WriteLine("Incorrect input");

            Console.ReadKey();
        }
    }
}
