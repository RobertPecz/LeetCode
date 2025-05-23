namespace LeetCode
{
    public class ValidSudokuSolution
    {
        //Create a hashset. Check the distinct values by at any new number the hashset count not incrementing. If the value not between 1-9 don't add to the hashset.
        //Check every row with a loop like:
        //for (int k = 0; k < jagged_arr[rowNumber].Length; k++) 
        //{ 
  
            // Print the elements in the row 
        //  Console.Write("{0} ", jagged_arr[rowNumber][k]); 
        //    
        //} 
        //Check every column with a loop like:
        //for (int i = columnNumber; i < jagged_arr.Length; i++)
        //{
            // Print the element in the column    
        //  Console.WriteLine("{0} ", jagged_arr[i][columnNumber])   
        //}
        //Check the 3x3 matrixes like:
        //Start number row: constant
        //End number row: constant+2row
        //End number column: start number row+2column
        //Loop index: start number row.
        //If loop index == end number column => Start number row +=1 and index == start number row.
        //If start number row > end number row => end number row = start number row +2
        //If loop index == end number row and end number row == array.column.Length => start number column = end number row +1 and end number row: start number row+2row and end number column: start number row+2column.
        public bool CheckSudokuRow(int[][] sudoku, int rowNumber)
        {
            for (int i = 0; i < sudoku[rowNumber].Length; i++)
            {
                Console.Write(sudoku[rowNumber][i]+ " ");
            }
            return true;
        }

        public bool CheckSudokuColumn(int[][] sudoku, int columnNumber)
        {
            for (int i = 0; i < sudoku.Length; i++)
            {
                Console.Write(sudoku[i][columnNumber]+ " ");
            }
            return true;
        }

        //Put this in a for loop which is looping +3 every iteration until reach end of the matrix. 
        //Use while loop, if row 7 new column, if row 7 and column jagged array 
        //length -1 exit loop. 
        public bool CheckSudokuMatrix(int[][] sudoku, int startNumberRow)
        {
            int endNumberRow = startNumberRow + 3;
            int endNumberColumn = startNumberRow + 3;

            for (int i = startNumberRow; i < endNumberColumn; i++)
            {
                for (int j = 0; j < endNumberRow; j++)
                {
                    Console.Write(sudoku[i][j]+ " ");
                }
                Console.WriteLine("");
            }
            return true;
        }
    }
}