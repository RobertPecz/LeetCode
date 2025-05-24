namespace LeetCode
{
    //https://leetcode.com/problems/ransom-note/description/
    public class RansomSolution
    {
        public bool CanConstruct(string ransomNote, string magazine) 
        {
            Dictionary<int, string> magazineDictionary = new Dictionary<int, string>();
            if(ransomNote.Length > magazine.Length)
            {
                return false;
            }
            
            for(int i = 0; i < magazine.Length; i++)
            {
                magazineDictionary.Add(i, magazine[i].ToString());               
            }

            for (int i = 0; i < ransomNote.Length; i++)
            {
               var valueElement = magazineDictionary.FirstOrDefault(element => element.Value == ransomNote[i].ToString()).Value;
               if(valueElement == null)
               {
                    return false;
               }
               else
               {
                magazineDictionary.Remove(magazineDictionary.FirstOrDefault(element => element.Value == ransomNote[i].ToString()).Key);
               }
            }
            return true;
        }
    }
}