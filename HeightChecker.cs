namespace LeetCode
{
    public class HeightCheckerSolution
    {
        //https://leetcode.com/explore/learn/card/fun-with-arrays/523/conclusion/3228/

        
        public int HeightChecker(int[] heights) 
        {
            int[] tempCopiedHeights = new int[heights.Length];
            Array.Copy(heights, tempCopiedHeights, heights.Length);
            int index = 0;
            int tallest = index + 1;
            int notInPlace = 0;

            while(index < tempCopiedHeights.Length)
            {
                if(tallest == tempCopiedHeights.Length)
                {
                    index++;
                    tallest = index + 1;
                }
                else if(tempCopiedHeights[index] > tempCopiedHeights[tallest])
                {
                    int temp = tempCopiedHeights[index];
                    tempCopiedHeights[index] = tempCopiedHeights[tallest];
                    tempCopiedHeights[tallest] = temp;
                    tallest++;
                }
                else
                {
                    tallest++;
                }
            }
            for (int i = 0; i < heights.Length; i++)
            {
                if(heights[i] != tempCopiedHeights[i])
                {
                    notInPlace++;
                }
            }

            return notInPlace;
        }
    }
}