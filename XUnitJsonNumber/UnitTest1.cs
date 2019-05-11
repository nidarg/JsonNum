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
            int actual = Program.GetIndexOfExponetialNotation(number);
            Assert.Equal(expected, actual);
        }
    }
}
