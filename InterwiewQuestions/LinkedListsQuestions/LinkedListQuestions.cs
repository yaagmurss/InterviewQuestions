using System;
using System.Collections.Generic;
using System.Text;

namespace InterwiewQuestions.LinkedLists
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


    public class LinkedListQuestions
    {
        public ListNode mergeTwoLists(ListNode list1, ListNode list2)
        {
            // create head to be returned and a pointer to track/append 
            // nodes
            ListNode head = new ListNode();
            ListNode ptr = head;

            // go through both linked lists until we reach the end of         
            // either 
            while (list1 != null && list2 != null)
            {
                // make next node of ptr the lesser of the two given 
                // nodes, and increment
                if (list1.val <= list2.val)
                {
                    ptr.next = list1;
                    ptr = ptr.next;
                    list1 = list1.next;
                }
                else
                {
                    ptr.next = list2;
                    ptr = ptr.next;
                    list2 = list2.next;
                }
            }

            // append the rest of the remaining ListNode
            if (list1 != null)
            {
                ptr.next = list1;
            }
            else
            {
                ptr.next = list2;
            }

            // return sorted linked list
            return head.next;
        }

        //public ListNode DeleteDuplicates(ListNode head)
        //{

        //}
    }

}
