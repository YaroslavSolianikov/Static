using System;

namespace Static_001
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number");
            Calculator.FirstNum = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Operation (+,-,*,/)");
            char sign = char.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            Calculator.SecondNum = double.Parse(Console.ReadLine());

            switch (sign)
            {
                case '+':
                    Console.WriteLine(Calculator.Sum());
                    break;
                case '-':
                    Console.WriteLine(Calculator.Sub());
                    break;
                case '*':
                    Console.WriteLine(Calculator.Mult());
                    break;
                case '/':
                    try
                    {
                        Console.WriteLine(Calculator.Div());
                    }
                    catch(Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
                default:
                    Console.WriteLine("Incorrect sign");
                    break;
            }
            Console.ReadKey();
        }
    }
}
