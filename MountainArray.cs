namespace LeetCode
{
    public class MountainArraySolution
    {
        public bool ValidMountainArray(int[] arr) 
        {
            bool isUphill = true;
            if(arr.Length < 3)
            {
                return false;
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if(i != 0 && i <= arr.Length -2 && arr[i] > arr[i-1] && arr[i] > arr[i+1])
                {
                    isUphill = false;
                }
                else if(isUphill && i < arr.Length -1 && arr[i] >= arr[i+1])
                {
                    return false;
                }
                else if(!isUphill && i < arr.Length -1 && arr[i] <= arr[i+1])
                {
                    return false;
                }
                else if(i == arr.Length -1 && isUphill)
                {
                    return false;
                }
            }
            return true;
        }
    }
}