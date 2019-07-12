using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCodeExperiments.Algorithms
{

    /*
     * You are given two non-empty linked lists representing two non-negative integers. The digits are stored in reverse order and each of their nodes contain a single digit. Add the two numbers and return it as a linked list.

        You may assume the two numbers do not contain any leading zero, except the number 0 itself.

        Example:

        Input: (2 -> 4 -> 3) + (5 -> 6 -> 4)
        Output: 7 -> 0 -> 8
        Explanation: 342 + 465 = 807.

    */
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }

    public static class AddTwoNumbers
    {
        public static ListNode ReturnCalculatedValue(ListNode l1, ListNode l2)
        {
            var reverseL1 = new ListNode(l1.val);
            var loop = true;

            while (loop)
            {
                if (l1.next != null)
                {
                    reverseL1.next = l1.next;
                }
                else
                {
                    loop = false;
                }
            }
           
            var result = new ListNode(1);

            return result;

        }

        public static ListNode ReverseValue(ListNode l1)
        {
            var loopthrough = true;
            ListNode reverseL1 = new ListNode(0);
            ListNode nextL1 = l1;
            while (loopthrough)
            {
                if (nextL1.next != null)
                {
                    nextL1 = nextL1.next;
                }
                else
                {
                    reverseL1 = nextL1.next;
                    loopthrough = false;
                }
                   
            }

            loopthrough = true;
            while (loopthrough)
            {
                if (l1.next != null)
                {
                    reverseL1.next = l1.next;
                }
                else
                {
                    loopthrough = false;
                }
            }

            return reverseL1;

        }
    }
}

