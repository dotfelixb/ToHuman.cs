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
            var ten = Worded.Lookup(10).Trim();
            Assert.Equal("Ten", ten);
        }

        [Fact]
        public void TwentyTwoToHuman()
        {
            var ttwo = 22.ToHuman();
            Assert.Equal("Twenty Two", ttwo);
        }

        [Fact]
        public void ThirtyToHuman()
        {
            var thirty = 30.ToHuman();
            Assert.Equal("Thirty", thirty);
        }

        [Fact]
        public void NinetySevenToHuman()
        {
            var nseven = 97.ToHuman();
            Assert.Equal("Ninety Seven", nseven);
        }
    }
}