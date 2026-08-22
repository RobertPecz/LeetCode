namespace LeetCode.Tests
{
    public class ArrayTests
    {
        [Test]
        public void SortArrayByParityPlacesEvenNumbersFirst()
        {
            var result = new ArrayParitySolution().SortArrayByParity(new[] { 3, 1, 2, 4 });

            Assert.That(result.Take(2).All(value => value % 2 == 0), Is.True);
            Assert.That(result.Skip(2).All(value => value % 2 != 0), Is.True);
        }

        [TestCase(new[] { 3, 2, 2, 3 }, 3, 2)]
        [TestCase(new[] { 0, 1, 2, 2, 3, 0, 4, 2 }, 2, 5)]
        public void RemoveElementReturnsLengthAndMovesOtherValues(int[] values, int value, int expectedLength)
        {
            var result = new DeleteArraySolution().RemoveElement(values, value);

            Assert.That(result, Is.EqualTo(expectedLength));
            Assert.That(values.Take(result), Does.Not.Contain(value));
        }

        [Test]
        public void RemoveElementLowercaseOverloadReturnsLength()
        {
            var values = new[] { 3, 2, 2, 3 };

            Assert.That(new DeleteArraySolution().removeElement(values, 3), Is.EqualTo(2));
            Assert.That(values.Take(2), Is.EqualTo(new[] { 2, 2 }));
        }

        [Test]
        public void RemoveDuplicatesReturnsNumberOfUniqueValues()
        {
            var values = new[] { 1, 1, 2, 2, 3 };

            var result = new DeleteArraySolution().RemoveDuplicates(values);

            Assert.That(result, Is.EqualTo(3));
            Assert.That(values.Take(result), Is.EqualTo(new[] { 1, 2, 3 }));
        }

        [Test]
        public void CheckIfExistFindsDouble()
        {
            Assert.That(new DoubleExistSolution().CheckIfExist(new[] { 10, 2, 5, 3 }), Is.True);
            Assert.That(new DoubleExistSolution().CheckIfExist(new[] { 3, 1, 7, 11 }), Is.False);
        }

        [Test]
        public void DoubleZeroExpandsZerosWithinFixedLength()
        {
            var values = new[] { 1, 0, 2, 3, 0, 4 };

            new DoubleZerosSolution().DoubleZero(values);

            Assert.That(values, Is.EqualTo(new[] { 1, 0, 0, 2, 3, 0 }));
        }

        [Test]
        public void FindNumbersCountsNumbersWithEvenDigits()
        {
            Assert.That(new EvenNumberDigitsSolution().FindNumbers(new[] { 12, 345, 2, 6, 7896 }), Is.EqualTo(2));
        }

        [Test]
        public void HeightCheckerCountsOutOfPlaceHeights()
        {
            Assert.That(new HeightCheckerSolution().HeightChecker(new[] { 1, 1, 4, 2, 1, 3 }), Is.EqualTo(3));
        }

        [Test]
        public void FindMaxConsecutiveOnesReturnsLongestRun()
        {
            Assert.That(new MaxConsSolution().FindMaxConsecutiveOnes(new[] { 1, 1, 0, 1, 1, 1 }), Is.EqualTo(3));
        }

        [Test]
        public void MergeCombinesSortedArrays()
        {
            var values = new[] { 1, 2, 3, 0, 0, 0 };

            new MergeTwoArraySolution().Merge(values, 3, new[] { 4, 5, 6 }, 3);

            Assert.That(values, Is.EqualTo(new[] { 1, 2, 3, 4, 5, 6 }));
        }

        [Test]
        public void MiddleNodeReturnsSecondMiddleForEvenLengthList()
        {
            var head = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4))));

            var result = new Solution().MiddleNode(head);

            Assert.That(result.val, Is.EqualTo(3));
        }

        [TestCase(new[] { 2, 1, 4, 7, 3, 2, 5 }, true)]
        [TestCase(new[] { 3, 5, 5 }, false)]
        [TestCase(new[] { 2, 1 }, false)]
        public void ValidMountainArrayValidatesShape(int[] values, bool expected)
        {
            Assert.That(new MountainArraySolution().ValidMountainArray(values), Is.EqualTo(expected));
        }

        [Test]
        public void MoveZeroesMovesZerosToTheEnd()
        {
            var values = new[] { 0, 1, 0, 3, 12 };

            new MoveZeroesSolution().MoveZeroes(values);

            Assert.That(values, Is.EqualTo(new[] { 1, 3, 12, 0, 0 }));
        }

        [Test]
        public void ReplaceElementsUsesGreatestElementOnTheRight()
        {
            var result = new ReplaceElementsSolution().ReplaceElements(new[] { 17, 18, 5, 4, 6, 1 });

            Assert.That(result, Is.EqualTo(new[] { 18, 6, 6, 6, 1, -1 }));
        }

        [Test]
        public void SortedSquaresReturnsSortedSquares()
        {
            var result = new SquareSortSolution().SortedSquares(new[] { -4, -1, 0, 3, 10 });

            Assert.That(result, Is.EqualTo(new[] { 0, 1, 9, 16, 100 }));
        }

        [TestCase(new[] { 3, 2, 1 }, 1)]
        [TestCase(new[] { 1, 2 }, 2)]
        [TestCase(new[] { 2, 2, 3, 1 }, 1)]
        public void ThirdMaxReturnsThirdDistinctMaximumOrMaximum(int[] values, int expected)
        {
            Assert.That(new ThirdMaximumSolution().ThirdMax(values), Is.EqualTo(expected));
        }

        [Test]
        public void TwoSumReturnsIndicesOfMatchingPair()
        {
            Assert.That(new TwoSumsSolution().TwoSum(new[] { 2, 7, 11, 15 }, 9), Is.EqualTo(new[] { 0, 1 }));
        }

        [TestCase(99, true)]
        [TestCase(23, false)]
        [TestCase(17190, true)]
        public void CheckDivisibility(int n, bool result)
        {
            Assert.That(new CheckDivisibilityByDigitSumAndProduct().CheckDivisibility(n), Is.EqualTo(result));
        }
    }
}