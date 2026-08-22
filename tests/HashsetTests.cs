namespace LeetCode.Tests
{
    public class HashsetTests
    {
        [Test]
        public void FindDisappearedNumbersReturnsMissingValues()
        {
            var result = new FindDisappearedNumberSolution().FindDisappearedNumbers(new[] { 4, 3, 2, 7, 8, 2, 3, 1 });

            Assert.That(result, Is.EqualTo(new[] { 5, 6 }));
        }

        [Test]
        public void SudokuRowCheckAcceptsRow()
        {
            var board = new[] { new[] { 5, 3, 4 } };

            Assert.That(new ValidSudokuSolution().CheckSudokuRow(board, 0), Is.True);
        }

        [Test]
        public void SudokuColumnCheckAcceptsColumn()
        {
            var board = new[] { new[] { 5 }, new[] { 3 }, new[] { 4 } };

            Assert.That(new ValidSudokuSolution().CheckSudokuColumn(board, 0), Is.True);
        }

        [Test]
        public void SudokuMatrixCheckAcceptsMatrix()
        {
            var board = new[]
            {
                new[] { 5, 3, 4 },
                new[] { 6, 7, 2 },
                new[] { 1, 9, 8 }
            };

            Assert.That(new ValidSudokuSolution().CheckSudokuMatrix(board, 0), Is.True);
        }
    }
}