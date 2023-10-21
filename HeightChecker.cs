namespace LeetCode
{
    public class HeightCheckerSolution
    {
        //https://leetcode.com/explore/learn/card/fun-with-arrays/523/conclusion/3228/

        //do a two pointer change and every swap increment an integer.
        public int HeightChecker(int[] heights) 
        {
            int index = 0;
            int tallestStudent = 1;
            int[] orderedHeights = new int[heights.Length];
            while(tallestStudent < heights.Length)
            {
                if(heights[index] > heights[tallestStudent])
                {
                    /*int temp = heights[index];
                    heights[index] = heights[tallestStudent];
                    heights[tallestStudent] = temp; */                
                    orderedHeights[tallestStudent] = heights[tallestStudent];
                    tallestStudent++;
                }
                else
                {
                    orderedHeights[index] = heights[index];
                    tallestStudent++;
                }

            }
            return 0;
        }
    }
}