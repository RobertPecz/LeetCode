namespace LeetCode
{
    //https://leetcode.com/problems/two-sum/description/
    public class TwoSumsSolution
    {
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