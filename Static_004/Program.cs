using System;

namespace Static_004
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = ArrayOperation.CreateArray(10);
            foreach (var item in array)
            {
                Console.Write($"{item} ");
            }
            array = array.OurSort();
            Console.WriteLine();
            foreach (var item in array)
            {
                Console.Write($"{item} ");
            }
            Console.ReadKey();
        }
    }
}
