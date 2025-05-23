namespace LeetCode
{
    public class ArrayParitySolution
    {
        public int[] SortArrayByParity(int[] nums) 
        {
            int lastOddNumber = 1;
            int index = 0;
            while (index < nums.Length)
            {
                if (lastOddNumber == nums.Length)
                {
                    index++;
                    lastOddNumber = index+1;
                }
                else if(nums[index] % 2 != 0 && nums[lastOddNumber] % 2 == 0)
                {
                    int temp = nums[index];
                    nums[index] = nums[lastOddNumber];
                    nums[lastOddNumber] = temp;
                    index++;
                }
                else
                {
                    lastOddNumber++;                                                    
                }
            }
            
            return nums;
        }
    }
}