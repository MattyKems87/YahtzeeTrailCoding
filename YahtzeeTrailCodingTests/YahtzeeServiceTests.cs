using System;
using System.Diagnostics.CodeAnalysis;
using Xunit;
using YahtzeeTrailCoding;

namespace YahtzeeTrailCodingTests
{
    [ExcludeFromCodeCoverage]
    public class YahtzeeServiceTests
    {
        [Fact]
        public void GetScore_SingleHighestValue()
        {
            //arrange
            int[] dice = { 9, 4, 2, 3, 5, 8, 2, 4, 2 };

            //act
            int result = YahtzeeService.GetScore(dice);

            //assert
            Assert.Equal(9, result);
        }

        [Fact]
        public void GetScore_Duplicates()
        {
            //arrange
            int[] dice = { 10, 2, 2, 2, 2, 2, 2, 2, 2, 3, 7, 7, 14 };

            //act
            int result = YahtzeeService.GetScore(dice);

            //assert
            Assert.Equal(16, result);
        }
    }
}
