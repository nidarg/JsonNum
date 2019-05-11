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

        public static int GetIndexOfExponetialNotation(string number)
        {
            int index = -1;
            int eCount = GetOccurenceCount("e", number);
            int ECount = GetOccurenceCount("E", number);
            if (eCount == 1 && ECount == 0)
            {

                int eIndex = number.IndexOf('e');
                //index = eIndex;
                return eIndex;
            }
            else if (ECount == 1 && eCount == 0)
            {
                int EIndex = number.IndexOf('E');
                //index = EIndex;
                return EIndex;
            }
            return index;
        }
    }
}
