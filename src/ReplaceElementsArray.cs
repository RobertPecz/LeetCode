namespace LeetCode
{
    //https://leetcode.com/problems/remove-element/description/
    public class ReplaceElementsSolution
    {
        public int[] ReplaceElements(int[] arr) 
        {        
            for (int i = 0; i < arr.Length; i++)
            {
                int biggestNumber = 0;
                for (int j = i+1; j < arr.Length; j++)
                {  
                    if(arr[j] > biggestNumber)
                    {
                        biggestNumber = arr[j];
                        arr[i] = arr[j];
                    }
                }
            }
            arr[arr.Length -1] = -1;
            return arr;
        }
    }
}