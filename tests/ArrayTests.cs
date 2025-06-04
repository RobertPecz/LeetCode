using LeetCode;

namespace LeetCodeTests
{
    public class ArrayTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(new int[] { 2, 7, 11, 15 }, 9, ExpectedResult = new int[] { 0, 1 })]
        [TestCase(new int[] { 3, 2, 4 }, 6, ExpectedResult = new int[] { 1, 2 })]
        [TestCase(new int[] { 3, 3 }, 6, ExpectedResult = new int[] { 0, 1 })]
        public int[] TwoSumsSolution(int[] nums, int target)
        {
            TwoSumsSolution solution = new TwoSumsSolution();
            return solution.TwoSum(nums, target);
        }

        [TestCase(new int[] { 3, 1, 2, 4 }, ExpectedResult = new int[] { 2, 4, 3, 1 })]
        [TestCase(new int[] { 0 }, ExpectedResult = new int[] { 0 })]
        public int[] ArrayParitySolution(int[] nums)
        {
            ArrayParitySolution arrayParitySolution = new ArrayParitySolution();
            return arrayParitySolution.SortArrayByParity(nums);
        }

        [TestCase(new int[] { 3, 1, 2, 4 }, ExpectedResult = new int[] { 1, 2, 3 })]
        [TestCase(new int[] { 1, 1 }, ExpectedResult = new int[] { 2 })]
        public int[] DisappearedNumberSolution(int[] nums)
        {
            FindDisappearedNumberSolution findDisappearedNumberSolution = new FindDisappearedNumberSolution();
            return findDisappearedNumberSolution.FindDisappearedNumbers(nums);
        }

        [TestCase(new int[] { 1, 0, 2, 3, 0, 4, 5, 0 }, ExpectedResult = new int[] { 1, 0, 0, 2, 3, 0, 0, 4 })]
        [TestCase(new int[] { 1, 2, 3 }, ExpectedResult = new int[] { 1, 2, 3, })]
        public int[] DuplicateZeroesSolution(int[] nums)
        {
            DoubleZerosSolution doubleZerosSolution = new DoubleZerosSolution();
            return doubleZerosSolution.DoubleZero(nums);
        }
    }
}