using ToHuman;
using Xunit;

namespace ToHumanTest
{
    public class TestThousands
    {
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