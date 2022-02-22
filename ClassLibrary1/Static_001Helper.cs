using System;
using System.Linq;
namespace ClassLibrary1
{
    public class Static_001Helper
    {
        public static double FirstNum { get; set; }
        public static double SecondNum { get; set; }
        public static double Sum() => FirstNum + SecondNum;
        public static double Sub() => FirstNum - SecondNum;
        public static double Mult() => FirstNum * SecondNum;
        public static double Div()
        {
            if (SecondNum == 0)
            {
                throw new DivideByZeroException("Second argument was zero!");
            }
            else
                return FirstNum / SecondNum;
        }
        public static double CelsiusToFahrenheit(string temperatureCelsius)
        {
            double tempCelsius = Convert.ToDouble(temperatureCelsius);
            return tempCelsius * 1.8 + 32;
        }
        public static double FahrenheitToCelsius(string temperatureFahrenheit)
        {
            double tempFahrenheit = Convert.ToDouble(temperatureFahrenheit);
            return Math.Round((tempFahrenheit - 32) / 1.8, 2);
        }
        public static int StrCount(string str, int pos)
        {
            int count = 0;
            if (pos <= 0)
            {
                throw new ArgumentException("Position was less than zero or equal to zero!");
            }
            else if (str == null)
            {
                throw new ArgumentException("String was null!");
            }
            else
            {
                for (int i = pos; i <= str.Length; i++)
                {
                    count++;
                }
                return count;
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
        public static int GetMaxElementOfDiagonal(int[,] array) //This method not from this homework but it was created for training
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


