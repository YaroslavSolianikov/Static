using System;
namespace Static_003
{
    static class StringExtension
    {
        public static int StrCount(this string str, int pos)
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
    }
}
