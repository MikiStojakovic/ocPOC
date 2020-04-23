using System;
using Xunit;

namespace CopartisOC.Domain.Tests
{
    public class DomainTests
    {
        [Fact]
        public void TrimTest()
        {
            var testCandidate = " Vako onako ";
            var actual = testCandidate.Trim();
            var expected = "Vako onako";

            Assert.Equal(expected, actual);
        }
    }
}
