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
    }
}