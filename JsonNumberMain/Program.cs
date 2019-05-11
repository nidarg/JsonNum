using System;

namespace JsonNumberMain
{
   public  class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static bool VerifyIfDigit(char start, char end, string number)
        {
            if (string.IsNullOrEmpty(number))
                return false;

            return start <= number[0] && number[0] <= end;
        }

        public static int GetOccurenceCount(string toCount, string number)
        {
            return number.Length - number.Replace(toCount, "").Length;
        }

        public static int GetOccurenceCountIgnoringCase(string number,char c)
        {
            int count = 0;
            foreach(char ch in number)
            {
                if(char.ToUpperInvariant(ch) == char.ToUpperInvariant(c))
                {
                    count++;
                }
            }
            return count;
        }

        public static int GetIndexOfExponentialNotation(string number)
        {
            char exponent = 'e';
            int charCount = GetOccurenceCountIgnoringCase(number, exponent);
            if(charCount==0||charCount == 1)
            {
                return number.IndexOf(exponent.ToString(), StringComparison.CurrentCultureIgnoreCase);
            }
            
            return -2;
        }
    }
}
