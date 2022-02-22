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
            try
            {
                s.StrCount(pos);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
