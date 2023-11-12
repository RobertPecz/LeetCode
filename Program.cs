namespace LeetCode
{
    public class Program
    {
        public static void Main()
        {
            int[] arr = {4,3,2,7,8,2,3,1};
            int[] arr1 = {2,2};
            int[] arr2 = {10,2,5,10,9,1,1,4,3,7};
            
            FindDisappearedNumberSolution findDisappearedNumberSolution = new FindDisappearedNumberSolution();
            var a = findDisappearedNumberSolution.FindDisappearedNumbers(arr2);
        }
    }
}
