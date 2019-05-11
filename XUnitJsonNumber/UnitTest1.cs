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
    }
}
