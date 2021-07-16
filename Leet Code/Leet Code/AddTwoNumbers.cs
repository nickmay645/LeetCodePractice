using System;

namespace Leet_Code
{

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

    public class Solution
    {

        //static void Main(string[] args)
        //{
        //    Solution solution = new Solution();
        //    ListNode l1 = new ListNode(2);
        //    l1.next = new ListNode(4);
        //    l1.next.next = new ListNode(3);

        //    ListNode l2 = new ListNode(5);
        //    l2.next = new ListNode(6);
        //    l2.next.next = new ListNode(4);

        //    var result = solution.AddTwoNumbers(l1, l2);

        //}
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            var result = new ListNode(0);
            var temp = result;
            var rem = 0;

            while(l1 != null || l2 != null || rem == 1)
            {
                var val1 = l1 == null ? 0 : l1.val;
                var val2 = l2 == null ? 0 : l2.val;
                var sum = val1 + val2 + rem;

                if(sum >= 10)
                {
                    rem = 1;
                    sum %= 10;
                }
                else
                {
                    rem = 0;
                }

                temp.next = new ListNode(sum);
                temp = temp.next;
                l1 = l1?.next;
                l2 = l2?.next;

            }
            return result.next;
        }
    }
}
