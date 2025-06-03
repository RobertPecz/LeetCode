using LeetCode;

namespace LeetCodeTests
{
    public class ArrayTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TwoSumsSolution()
        {
            TwoSumsSolution solution = new TwoSumsSolution();
            var elements = solution.TwoSum(new int[] { 2, 7, 11, 15 }, 9);
        }
    }
}