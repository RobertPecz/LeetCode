using LeetCode;

namespace LeetCodeTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            TwoSumsSolution solution = new TwoSumsSolution();
            var elements = solution.TwoSum(new int[] { 2, 7, 11, 15 }, 9);
        }
    }
}