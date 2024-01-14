namespace LeetCode
{
    public class Program
    {
        public static void Main()
        {
            int[] arr = { 2,7,11,15 };
            int[] arr1 = { 3,2,4 };
            int[] arr2 = { 3,3 };

            TwoSumsSolution twoSumsSolution = new TwoSumsSolution();

            var a = twoSumsSolution.TwoSum(arr2, 6);
        }
    }
}
