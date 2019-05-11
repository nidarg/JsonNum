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
    }
}
