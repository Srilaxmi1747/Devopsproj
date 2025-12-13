using Xunit;
using Devopsproj.App;

namespace Devopsproj.Tests
{
    public class CalculatorTests
    {
        [Fact]
        public void Add_ReturnsCorrectSum()
        {
            Assert.Equal(5, Program.Add(2, 3));
        }
    }
}
