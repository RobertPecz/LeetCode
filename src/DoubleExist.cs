
namespace LeetCode
{
    public class DoubleExistSolution
    {
        public bool CheckIfExist(int[] arr) 
        {
            bool isNumberExist = false;
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum = arr[i] * 2;
                for (int j = 0; j < arr.Length; j++)
                {
                    if(sum == arr[j] && j != i)
                    {
                        isNumberExist = true;
                        return isNumberExist;
                    }
                }      
            }
            return isNumberExist;
        }
    }
}