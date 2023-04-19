using Algorithms.Solutions;

namespace Algorithms.Tests.Tests
{
    public class TwoNumberSumTest
    {
        [Fact]
        public void TwoNumberSum_Inputs_ReturnOk()
        {
            TwoNumberSum twoNumberSum = new TwoNumberSum();

            var result = twoNumberSum.Solution(new int[] { 3, 5, -4, 8, 11, 1, -1, 6 }, 10);

            Assert.NotNull(result);
            Assert.Equal(10, result.Sum());
            Assert.Equal(new int[] { -1, 11 }, result.OrderBy(x => x).ToArray());
        }
    }
}
