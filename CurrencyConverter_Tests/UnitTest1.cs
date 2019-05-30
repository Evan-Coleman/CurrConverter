using System;
using Xunit;
using ConsoleApp10;
using ConsoleApp10.Data.Models;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("19.23", 1, RatesCurrCodes.USD, RatesCurrCodes.MXN)]
        [InlineData("27", 30, RatesCurrCodes.USD, RatesCurrCodes.EUR)]
        [InlineData("1.4040561622464898595943837754", 30, RatesCurrCodes.MXN, RatesCurrCodes.EUR)]
        [InlineData("39.303797468354430379746835443", 23, RatesCurrCodes.GBP, RatesCurrCodes.CAD)]
        [InlineData("50", 50, RatesCurrCodes.USD, RatesCurrCodes.USD)]
        [InlineData("89.1", 66, RatesCurrCodes.USD, RatesCurrCodes.CAD)]
        [InlineData("48.888888888888888888888888889", 66, RatesCurrCodes.CAD, RatesCurrCodes.USD)]
        public void TestConverterMocked_WithInlineData(string expected, decimal num, string fromCurr, string toCurr)
        {
            RatesRepoMock rates = new RatesRepoMock();
            var converter = new CurrConverter(rates);

            Assert.Equal(Convert.ToDecimal(expected), converter.Convert(num, fromCurr, toCurr));
        }
    }
}
