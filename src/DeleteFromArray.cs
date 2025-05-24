namespace LeetCode
{
    //Problem not found
    public class DeleteArraySolution
    {
        public int Length { get; set; }

        public void DeleteFromIndex(int[] array, int indexOfAnElement, int length)
        {
            for(int i = indexOfAnElement + 1; i < length; i++)
            {
                array[i - 1] = array[i];
            }
            length--;
        }

        public int RemoveElement(int[] nums, int val)
        {
            int notMatchingElement = 0;
            int length = nums.Length -1;
            int index = 0;

            if(nums.Length == 0 || nums.All(element => element == val))
            {
                return index;
            }

            while(index < nums.Length && length >= 0)
            {
                if(nums[index] == val && nums[length] != val)
                {
                    nums[index] = nums[length];
                    index++;
                    length--;
                }
                else if(nums[index] == val && nums[length] == val && index != length)
                {
                    length--;
                }               
                else if(nums[index] != val)
                {
                    index++;
                    notMatchingElement++;
                }
                else
                {
                    index++;
                }
            }
            
            return notMatchingElement;
        }

        public int removeElement(int[] nums, int val) 
        {
            int index = 0;
            for (int i = 0; i < nums.Length; i++) 
            {
                if (nums[i] != val) 
                {
                    nums[index] = nums[i];
                    index++;
                }
        }

        return index;
        }

        public int RemoveDuplicates(int[] nums) 
        {
            int index = 0;
            int unique = 1;
            for (int i = 0; i < nums.Length; i++)
            {
                if(nums[i] != nums[index])
                {
                    unique++;
                    index++;
                    nums[index] = nums[i];
                }
            }
            return unique;
        }
    }
}