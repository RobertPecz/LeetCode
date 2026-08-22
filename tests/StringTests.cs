namespace LeetCode.Tests
{
    public class StringTests
    {
        [TestCase("a", "b", false)]
        [TestCase("aa", "aab", true)]
        [TestCase("abc", "ab", false)]
        public void CanConstructChecksAvailableMagazineCharacters(string ransomNote, string magazine, bool expected)
        {
            Assert.That(new RansomSolution().CanConstruct(ransomNote, magazine), Is.EqualTo(expected));
        }
    }
}