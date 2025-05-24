using System.Text;

namespace LeetCode
{
    //https://leetcode.com/problems/find-numbers-with-even-number-of-digits/description/
    public class EvenNumberDigitsSolution 
    {
        public int FindNumbers(int[] nums) 
        {
            int numberOfEvenNumbers = 0;
            StringBuilder numberConverter = new StringBuilder();
            for(int i = 0; i < nums.Length; i++)
            {
                numberConverter.Append(nums[i].ToString());
                if(numberConverter.Length % 2 == 0)
                {
                    numberOfEvenNumbers++;
                }
                numberConverter.Clear();
            }
            return numberOfEvenNumbers;
        }
    }
}