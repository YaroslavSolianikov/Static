using System;
using System.Linq;
namespace ClassLibrary1
{
    public class Static_Helper
    {
        private const double firstFormulaCosntant = 1.8;
        private const int secondFormulaCosntant = 32;

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
            return temperatureCelsius * firstFormulaCosntant + secondFormulaCosntant;
        }

        public static double FahrenheitToCelsius(double temperatureFahrenheit)
        {
            return Math.Round((temperatureFahrenheit - secondFormulaCosntant) / firstFormulaCosntant, 2);
        }

        public static int GetNumberOfElementsFromPosition(string str, int pos)
        {
            if (pos > 0 && str != null)
            {
                return str.Length - pos + 1;
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
            int temp;
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }

            return array;
        }

        public static int GetMaxElementOfDiagonal(int[,] array)
        {
            if (array != null && array.Length != 0)
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
            else if (array == null)
            {
                throw new ArgumentException("array was null!");
            }
            else
            {
                throw new ArgumentException("array was empty!");
            }
        }
    }
}


