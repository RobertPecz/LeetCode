namespace LeetCode
{
    //https://leetcode.com/problems/merge-sorted-array/description/
    public class MergeTwoArraySolution
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n) 
        {
            int lastElement = m + n -1;
            while(m -1 >= 0 && n -1 >= 0)
            {
                if (nums1[m-1] > nums2[n-1])
                {
                    nums1[lastElement] = nums1[m-1];
                    m--;                   
                }
                else if(nums2[n-1] > nums1[m-1])
                {
                    nums1[lastElement] = nums2[n-1];
                    n--;
                    
                }
                lastElement--;
            }
            while(n -1 >= 0)
            {
                nums1[lastElement] = nums2[n-1];
                lastElement--;
                n--;
            }
        }
    }
}