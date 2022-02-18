namespace Static_003
{
    static class StringExtension
    {
        public static int StrCount(this string str, int pos)
        {
            int count = 0;
            for (int i = pos; i <= str.Length; i++)
            {
                count++;
            }
            return count;
        }
    }
}
