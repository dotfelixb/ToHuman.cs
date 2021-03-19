using ToHuman;
using Xunit;

namespace ToHumanTest
{
    public class TestHundreds
    {
        [Fact]
        public void ThreeHundredTwentyFour()
        {
            var ttfour = 324.ToHuman();
            Assert.Equal("Three Hundred Twenty Four", ttfour);
        }

        [Fact]
        public void OneThousand()
        {
            var othou = 1000.ToHuman();
            Assert.Equal("One Thousand", othou);
        }

        [Fact]
        public void OneThousandOne()
        {
            var othouo = 1001.ToHuman();
            Assert.Equal("One Thousand One", othouo);
        }

        [Fact]
        public void OneThousandTwentyFive()
        {
            var othoutfive = 1025.ToHuman();
            Assert.Equal("One Thousand Twenty Five", othoutfive);
        }

        [Fact]
        public void OneHundredTen()
        {
            var ohundten = 110.ToHuman();
            Assert.Equal("One Hundred Ten", ohundten);
        }

        [Fact]
        public void OneHundredFortyTwo()
        {
            var ohundten = 142.ToHuman(compound: true);
            Assert.Equal("One Hundred Forty-Two", ohundten);
        }
    }
}