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