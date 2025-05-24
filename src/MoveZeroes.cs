namespace LeetCode
{
    //https://leetcode.com/problems/move-zeroes/description/
    public class MoveZeroesSolution
    {
        public void MoveZeroes(int[] nums) 
        {           
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i+1; j < nums.Length; j++)
                {
                    if(nums[i] == 0 && nums[j] != 0)
                    {
                        int temp = nums[i];
                        nums[i] = nums[j];
                        nums[j] = temp;
                    }
                }
            }
        }
    }
}