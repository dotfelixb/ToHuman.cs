using System;
using Xunit;
using ToHuman;

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
    }
}
