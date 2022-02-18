using System;

namespace Static_003
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string");
            string s = Console.ReadLine();
            Console.WriteLine("Enter the position");
            int pos = int.Parse(Console.ReadLine());
            if (pos > 0)
            {
                Console.WriteLine($"{s.StrCount(pos)} elements in string ");
            }
            else
            {
                Console.WriteLine("incorrect input");
            }
            Console.ReadKey();
        }
    }
}
