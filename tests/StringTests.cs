using LeetCode;

namespace LeetCodeTests
{
    public class StringTests
    {
        public void Setup()
        { }

        [TestCase("a", "b", ExpectedResult = false)]
        [TestCase("aa", "ab", ExpectedResult = false)]
        [TestCase("aa", "aab", ExpectedResult = true)]
        public bool RansomNodeTests(string ransomNote, string magazine)
        {
            RansomSolution solution = new RansomSolution();
            return solution.CanConstruct(ransomNote, magazine);
        }
    }
}