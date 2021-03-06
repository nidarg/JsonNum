using System;
using Xunit;
using JsonNumberMain;

namespace XUnitJsonNumber
{
    public class UnitTest1
    {
        [Theory]
        [InlineData('0','9',"abc3fhf",true)]
        public void TestIfStringHasDigits(char start,char end,string s,bool expected)
        {
            bool actual = Program.VerifyIfDigit(start, end, s.Substring(3));
            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData(".", "12.34.5.", 3)]
        public void TestCountOfDotInString(string toCount, string number, int expected)
        {
            int actual = Program.GetOccurenceCount(toCount,number);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("12E485", 2)]
        public void GetIndexOfE(string number, int expected)
        {
            int actual = Program.GetIndexOfExponentialNotation(number);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("12E4e5",'e', 2)]
        public void VerifyOccurenceOfCharIgnoringCase(string number,char c, int expected)
        {
            int actual = Program.GetOccurenceCountIgnoringCase(number,c);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("12E4e5", '1', true)]
        public void VerifyMatchingCharacter(string number, char c, bool expected)
        {
            bool actual = Program.MatchCharacter(number, c);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("12.34E2", true)]
        [InlineData("12.34E-2", true)]
        public void VerifyExponentialNotationPass(string number, bool expected)
        {
            bool actual = Program.VerifyExponentialNotation(number);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("0.2E4e5",  true)]
        [InlineData("-3.2E4e5", true)]
        public void VerifyNegativeNumberPass(string number, bool expected)
        {
            bool actual = Program.VerifyNegativeNumbers(number);
            Assert.Equal(expected, actual);
        }


        [Theory]
        [InlineData("0.24e5", true)]
        [InlineData("-3.24e-2", true)]
        public void VerifyFinalNumberPass(string number, bool expected)
        {
            bool actual = Program.VerifyFinalNumber(number);
            Assert.Equal(expected, actual);
        }
    }
}
