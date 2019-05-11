using System;

namespace JsonNumberMain
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string s = Console.ReadLine();
            if (VerifyFinalNumber(s))
            {
                Console.WriteLine("Valid");
            }
            else Console.WriteLine("Invalid");

            Console.Read();
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

        public static int GetOccurenceCountIgnoringCase(string number, char c)
        {
            int count = 0;
            foreach (char ch in number)
            {
                if (char.ToUpperInvariant(ch) == char.ToUpperInvariant(c))
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
            if (charCount == 0 || charCount == 1)
            {
                return number.IndexOf(exponent.ToString(), StringComparison.CurrentCultureIgnoreCase);
            }

            return -2;
        }

        public static bool MatchCharacter(string number, char pattern)
        {
            return !string.IsNullOrEmpty(number) && number[0] == pattern;
        }

        public static bool VerifyExponentialNotation(string number)
        {
            int dotPosition = number.IndexOf('.');
            int dotCount = GetOccurenceCount(".", number);
            int indexOfExponent = GetIndexOfExponentialNotation(number);
            if (indexOfExponent == -2) return false;
            if (indexOfExponent == -1) return true;

            string afterExponent = number.Substring(indexOfExponent + 1);
            int index = 0;

            if (
                (dotPosition > 0) &&
                (indexOfExponent > dotPosition + 1) &&
                (dotCount == 1))
            {
                if (afterExponent.Length == 1)
                {
                    return VerifyIfDigit('0', '9', afterExponent.Substring(index));
                }
                else if (afterExponent.Length == 2)
                {
                    if (
                        (MatchCharacter(afterExponent.Substring(index), '+')
                        || MatchCharacter(afterExponent.Substring(index), '-'))
                        && VerifyIfDigit('0', '9', afterExponent.Substring(index + 1))
                        )
                    {
                        return true;
                    }

                }

            }
            return false;

        }

        public static bool VerifyNegativeNumbers(string number)
        {
            int index = 0;

            return MatchCharacter( number.Substring(index), '-') || MatchCharacter( number.Substring(index), '0');
           
        }

        public static bool VerifyFinalNumber(string number)
        {

            string onlyDigits = number.Replace("-", "").Replace("e", "").Replace("E", "").Replace("+", "").Replace(".", "");
            Console.WriteLine(onlyDigits);
            for (int i = 0; i < onlyDigits.Length; i++)
            {
                if (!VerifyIfDigit('0', '9', onlyDigits.Substring(i))) return false;
            }
            if (VerifyNegativeNumbers(number) && VerifyExponentialNotation(number)) return true;
            return false;

        }

    }
}
