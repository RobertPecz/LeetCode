namespace LeetCode
{
    public class ThirdMaximumSolution
    {
        public int ThirdMax(int[] nums)
        {
            Array.Sort(nums);
            int thirdBiggestNumber = nums[nums.Length-1];
            int secondSwitch = 0;           
            for (int i = nums.Length -1; i >= 0; i--)
            {
                if(secondSwitch == 2)
                {
                    return thirdBiggestNumber;
                }
                else if(nums[i] < thirdBiggestNumber)
                {
                    secondSwitch++;
                    thirdBiggestNumber = nums[i];
                }
            }
            if(secondSwitch != 2)
            {
                return nums[nums.Length-1];
            }
            return thirdBiggestNumber;
        }
    }
}