namespace LeetCode
{
    //https://leetcode.com/problems/squares-of-a-sorted-array/description/
    public class SquareSortSolution 
    {
        public int[] SortedSquares(int[] nums) 
        {
            int index = nums.Length - 1;
            int fromBeginning = 0;
            int fromEnd = nums.Length - 1;
            int[] solutionArray = new int[nums.Length];
            while(index >= 0)
            {
                if(Math.Abs(nums[fromBeginning]) < Math.Abs(nums[fromEnd]))
                {                   
                    solutionArray[index] = nums[fromEnd] * nums[fromEnd];
                    fromEnd--;
                    index--; 
                }
                else if(Math.Abs(nums[fromBeginning]) > Math.Abs(nums[fromEnd]))
                {                  
                    solutionArray[index] = nums[fromBeginning] * nums[fromBeginning];
                    fromBeginning++;
                    index--; 
                }
                else
                {
                    solutionArray[index] = nums[fromBeginning] * nums[fromBeginning];
                    fromBeginning++;
                    index--; 
                }
            }
            return solutionArray;
        }
    }
}