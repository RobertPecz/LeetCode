namespace LeetCode
{
    public class TwoSumsSolution
    {
        /*Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.

        You may assume that each input would have exactly one solution, and you may not use the same element twice.

        You can return the answer in any order.*/

        /*2 <= nums.length <= 104
        -109 <= nums[i] <= 109
        -109 <= target <= 109
        [2,7,11,15]9
        [3,2,4]6
        [3,3]6*/
        public int[] TwoSum(int[] nums, int target) 
        {
            int index = 0;
            int jndex = 1;
            if(nums.Length == 2)
            {
                return new int[] { 0, 1 };
            }
            while(index < nums.Length / 2)
            {
                if(jndex == nums.Length)
                {
                    index++;
                    jndex = index+1;
                }               
                if(index != jndex && nums[index] + nums[jndex] == target)
                {
                    return new int[] { index, jndex };
                }
                else if(jndex < nums.Length || index == jndex)
                {
                    jndex++;
                }
            }
            return null;
        }
    }
}