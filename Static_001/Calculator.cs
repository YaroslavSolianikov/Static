using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_001
{
    static class Calculator
    {
        public static double FirstNum { get; set; }
        public static double SecondNum { get; set; }
        public static void Sum() => Console.WriteLine($"Result: {FirstNum + SecondNum}");
        public static void Sub() => Console.WriteLine($"Result: {FirstNum - SecondNum}");
        public static void Mult() => Console.WriteLine($"Result: {FirstNum * SecondNum}");
        public static void Div() => Console.WriteLine($"Result: {FirstNum / SecondNum}");
    }
}
