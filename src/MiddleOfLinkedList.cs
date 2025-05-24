namespace LeetCode
{
    //https://leetcode.com/problems/middle-of-the-linked-list/description/
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val=0, ListNode next = null) 
        {
           this.val = val;
           this.next = next;
        }
    }

    public class Solution 
    {
        public ListNode MiddleNode(ListNode head) 
        {
            ListNode endNode = head;
            ListNode middleNode = head;

            while(endNode != null && endNode.next != null)
            {               
                middleNode = middleNode.next;
                endNode = endNode.next.next;
            }
            return middleNode;
        }
    }

}