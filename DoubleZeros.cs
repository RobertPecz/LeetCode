namespace LeetCode
{
    //1, 0, 2, 3, 0, 4, 5, 0
    public class DoubleZerosSolution
    {
        public void DoubleZero(int[] inputArray)
        {
            int j = 0;
            int[] tempArray = new int[inputArray.Length];
            for (int i = 0; i < inputArray.Length; i++)
            {
                if (j > tempArray.Length -1)
                {
                    break;
                }

                else if (j == tempArray.Length -1 && inputArray[i] == 0)
                {
                    tempArray[j] = inputArray[i];
                    break;
                }

                else if(inputArray[i] == 0)
                {
                    tempArray[j] = inputArray[i];
                    j++;
                    tempArray[j] = inputArray[i]; 
                    j++;                   
                }
                
                else
                {
                    tempArray[j] = inputArray[i];
                    j++;
                }
            }

            Array.Copy(tempArray, inputArray, tempArray.Length);
        }
            
    }
}