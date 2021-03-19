using ToHuman;
using Xunit;

namespace ToHumanTest
{
    public class TestTens
    {
        [Fact]
        public void TenToHumand()
        {
            var ten = 10.ToHuman();
            Assert.Equal("Ten", ten);
        }

        [Fact]
        public void WordLookup()
        {
            Assert.Equal("Ten", Worded.Lookup(10));
        }

        [Fact]
        public void TwentyTwoToHuman()
        {
            var ttwo = 22.ToHuman();
            Assert.Equal("Twenty Two", ttwo);
        }

        [Fact]
        public void ThreeHundredTwentyFour()
        {
            var ttfour = 324.ToHuman();
            Assert.Equal("Three Hundred Twenty Four", ttfour);
        }
    }
}