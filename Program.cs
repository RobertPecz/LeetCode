namespace LeetCode
{
    public class Program
    {
        public static void Main()
        {
            int[][] sudoku = new int[][]
            {
                new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 },
                new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 },
                new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 },
                new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 },
                new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 },
                new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 },
                new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 },
                new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 },
                new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }
            };
            ValidSudokuSolution validSudokuSolution = new ValidSudokuSolution();

            var row = validSudokuSolution.CheckSudokuRow(sudoku, 0);

            Console.WriteLine("");

            var column = validSudokuSolution.CheckSudokuColumn(sudoku, 0);

            Console.WriteLine("");

            var matrix = validSudokuSolution.CheckSudokuMatrix(sudoku, 0);
        }
    }
}
