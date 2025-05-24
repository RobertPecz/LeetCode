namespace LeetCode
{
    //https://leetcode.com/problems/find-all-numbers-disappeared-in-an-array/description/
    public class FindDisappearedNumberSolution
    {
        public IList<int> FindDisappearedNumbers(int[] nums) 
        {
            var res=new HashSet<int>(Enumerable.Range(1,nums.Length));
            foreach (var item in nums)
            {
                res.Remove(item);
            }
            return res.ToArray();   
        }
    }
}