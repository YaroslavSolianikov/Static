using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                    Calculator.Sum();
                    break;
                case '-':
                    Calculator.Sub();
                    break;
                case '*':
                    Calculator.Mult();
                    break;
                case '/':
                    Calculator.Div();
                    break;
                default:
                    Console.WriteLine("Incorrect sign");
                    break;
            }
            Console.ReadKey();
        }
    }
}
