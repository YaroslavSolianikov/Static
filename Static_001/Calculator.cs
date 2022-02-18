using System;

namespace Static_001
{
    static class Calculator
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
    }
}
