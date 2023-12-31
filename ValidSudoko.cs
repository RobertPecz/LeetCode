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
        public void foo()
        {
            int[][] jagged_arr = new int[4][]; 
            jagged_arr[0] = new int[] {1, 2, 3, 4}; 
            jagged_arr[1] = new int[] {11, 34, 67}; 
            jagged_arr[2] = new int[] {89, 23}; 
            jagged_arr[3] = new int[] {0, 45, 78, 53, 99}; 
            for (int i = 0; i < jagged_arr.Length; i++)
            {
                Console.WriteLine(jagged_arr[i][0]);
            }
        }
    }
}