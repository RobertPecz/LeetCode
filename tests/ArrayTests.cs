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
        public int[] TwoSumsSolutionTests(int[] nums, int target)
        {
            TwoSumsSolution solution = new TwoSumsSolution();
            return solution.TwoSum(nums, target);
        }

        [TestCase(new int[] { 3, 1, 2, 4 }, ExpectedResult = new int[] { 2, 4, 3, 1 })]
        [TestCase(new int[] { 0 }, ExpectedResult = new int[] { 0 })]
        public int[] ArrayParitySolutionTests(int[] nums)
        {
            ArrayParitySolution arrayParitySolution = new ArrayParitySolution();
            return arrayParitySolution.SortArrayByParity(nums);
        }

        [TestCase(new int[] { 3, 1, 2, 4 }, ExpectedResult = new int[] { 1, 2, 3 })]
        [TestCase(new int[] { 1, 1 }, ExpectedResult = new int[] { 2 })]
        public int[] DisappearedNumberSolutionTests(int[] nums)
        {
            FindDisappearedNumberSolution findDisappearedNumberSolution = new FindDisappearedNumberSolution();
            return findDisappearedNumberSolution.FindDisappearedNumbers(nums);
        }

        [TestCase(new int[] { 1, 0, 2, 3, 0, 4, 5, 0 }, ExpectedResult = new int[] { 1, 0, 0, 2, 3, 0, 0, 4 })]
        [TestCase(new int[] { 1, 2, 3 }, ExpectedResult = new int[] { 1, 2, 3, })]
        public int[] DuplicateZeroesSolutionTests(int[] nums)
        {
            DoubleZerosSolution doubleZerosSolution = new DoubleZerosSolution();
            return doubleZerosSolution.DoubleZero(nums);
        }

        [TestCase(new int[] { 12, 345, 2, 6, 7896 }, ExpectedResult = 2)]
        [TestCase(new int[] { 555, 901, 482, 1771 }, ExpectedResult = 1)]
        public int EvenNumberDigitsSolutionTests(int[] nums)
        {
            EvenNumberDigitsSolution evenNumberDigitsSolution = new EvenNumberDigitsSolution();
            return evenNumberDigitsSolution.FindNumbers(nums);
        }

        [TestCase(new int[] { 1, 1, 4, 2, 1, 3 }, ExpectedResult = 3)]
        [TestCase(new int[] { 5, 1, 2, 3, 4 }, ExpectedResult = 5)]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, ExpectedResult = 0)]
        public int HeightCheckerSolutionTests(int[] nums)
        {
            HeightCheckerSolution heightCheckerSolution = new HeightCheckerSolution();
            return heightCheckerSolution.HeightChecker(nums);
        }

        [TestCase(new int[] { 1, 1, 0, 1, 1, 1 }, ExpectedResult = 3)]
        [TestCase(new int[] { 1, 0, 1, 1, 0, 1 }, ExpectedResult = 2)]
        public int MaxConsSolutionTests(int[] nums)
        {
            MaxConsSolution maxConsSolution = new MaxConsSolution();
            return maxConsSolution.FindMaxConsecutiveOnes(nums);
        }

        [TestCase(new int[] { 1, 2, 3, 0, 0, 0 }, 3, new int[] { 2, 5, 6 }, 3)]
        [TestCase(new int[] { 1 }, 1, new int[] { }, 0)]
        [TestCase(new int[] { 0 }, 0, new int[] { 1 }, 1)]
        public void MergeTwoArraySolutionTests(int[] nums1, int m, int[] nums2, int n)
        {
            MergeTwoArraySolution mergeTwoArraySolution = new MergeTwoArraySolution();
            mergeTwoArraySolution.Merge(nums1, m, nums2, n);
            var testArray = new int[] { 1, 2, 2, 3, 5, 6 };
            var isTheTwoArrayHasTheSameElements = nums1.SequenceEqual(testArray);
        }

        [TestCase(new int[] { 2, 1 }, ExpectedResult = false)]
        [TestCase(new int[] { 3, 5, 5 }, ExpectedResult = false)]
        [TestCase(new int[] { 0, 3, 2, 1 }, ExpectedResult = true)]
        public bool MountainArraySolutionTests(int[] nums)
        {
            MountainArraySolution mountainArraySolution = new MountainArraySolution();
            return mountainArraySolution.ValidMountainArray(nums);
        }

        [TestCase(new int[] { 0, 1, 0, 3, 12 })]
        public void MoveZeroesSolutionTests(int[] nums)
        {
            MoveZeroesSolution moveZeroesSolution = new MoveZeroesSolution();
            moveZeroesSolution.MoveZeroes(nums);
            var testArray = new int[] { 1, 3, 12, 0, 0 };
            var isTheTwoArrayHasTheSameElements = nums.SequenceEqual(testArray);
        }

        [TestCase(new int[] { -4, -1, 0, 3, 10 }, ExpectedResult = new int[] { 0, 1, 9, 16, 100 })]
        [TestCase(new int[] { -7, -3, 2, 3, 11 }, ExpectedResult = new int[] { 4, 9, 9, 49, 121 })]
        public int[] SquareSortSolutionTests(int[] nums)
        {
            SquareSortSolution squareSortSolution = new SquareSortSolution();
            return squareSortSolution.SortedSquares(nums);
        }

        [TestCase(new int[] { 3, 2, 1 }, ExpectedResult = 1)]
        [TestCase(new int[] { 1, 2 }, ExpectedResult = 2)]
        [TestCase(new int[] { 2, 2, 3, 1 }, ExpectedResult = 1)]
        public int ThirdMaximumSolutionTests(int[] nums)
        {
            ThirdMaximumSolution thirdMaximumSolution = new ThirdMaximumSolution();
            return thirdMaximumSolution.ThirdMax(nums);
        }
    }
}