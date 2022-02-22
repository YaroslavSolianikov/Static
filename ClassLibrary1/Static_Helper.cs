using System;
using System.Linq;
namespace ClassLibrary1
{
    public class Static_Helper
    {
        private const double FirstFormulaCosntant = 1.8;
        private const int SecondFormulaCosntant = 32;

        public static double Sum(double firstNum, double secondNum) => firstNum + secondNum;

        public static double Sub(double firstNum, double secondNum) => firstNum - secondNum;

        public static double Mult(double firstNum, double secondNum) => firstNum * secondNum;

        public static double Div(double firstNum, double secondNum)
        {
            if (secondNum != 0)
            {
                return firstNum / secondNum;
            }
            else
            {
                throw new DivideByZeroException("Second argument was zero!");
            }
        }

        public static double CelsiusToFahrenheit(double temperatureCelsius)
        {
            return temperatureCelsius * FirstFormulaCosntant + SecondFormulaCosntant;
        }

        public static double FahrenheitToCelsius(double temperatureFahrenheit)
        {
            return Math.Round((temperatureFahrenheit - SecondFormulaCosntant) / FirstFormulaCosntant, 2);
        }

        public static int StrCount(string str, int pos)
        {
            int count = 0;
            if (pos > 0 && str != null)
            {
                for (int i = pos; i <= str.Length; i++)
                {
                    count++;
                }
                return count;
            }
            else if (str == null)
            {
                throw new ArgumentException("String was null!");
            }
            else
            {
                throw new ArgumentException("Position was less than zero or equal to zero!");
            }
        }

        public static int[] OurSort(int[] array)
        {
            var sortedArray = from i in array
                              orderby i
                              select i;
            array = sortedArray.ToArray();
            return array;
        }

        public static int GetMaxElementOfDiagonal(int[,] array)
        {
            int maxOfDiagonal = array[0, 0];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (j == i)
                    {
                        if (maxOfDiagonal < array[i, j])
                        {
                            maxOfDiagonal = array[i, j];
                        }
                    }
                }
            }
            return maxOfDiagonal;
        }
    }
}


