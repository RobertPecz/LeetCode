namespace LeetCode
{
    //https://leetcode.com/problems/max-consecutive-ones/description/
    public class MaxConsSolution
    {
        public int FindMaxConsecutiveOnes(int[] nums) 
        {
            int maxNumber = 0;
            int tempMaxNumber = 0;
            for(int i = 0; i < nums.Length; i++)
            {
                if(nums[i] == 0)
                {
                    tempMaxNumber = 0;
                }
                else
                {
                    tempMaxNumber++;
                }
                if(tempMaxNumber > maxNumber)
                {
                    maxNumber = tempMaxNumber;
                }
            }    
            return maxNumber;
        }
    }
}