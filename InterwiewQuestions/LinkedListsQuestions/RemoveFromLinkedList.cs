using System;
using System.Collections.Generic;
using System.Text;

namespace InterwiewQuestions.LinkedLists
{
    public class RemoveFromLinkedList
    { 

        /* Linked list Node*/
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

        public ListNode removeDuplicates(ListNode head)
        {
            /*Another reference to head*/
            ListNode current = head;

            /* Pointer to store the next 
            pointer of a node to be deleted*/
            ListNode next_next;

            /* do nothing if the list is empty */
            if (head == null)
                return head;

            /* Traverse list till the last node */
            while (current.next != null)
            {

                /*Compare current node with the next node */
                if (current.val == current.next.val)
                {
                    next_next = current.next.next;
                    current.next = null;
                    current.next = next_next;
                }
                else // advance if no deletion
                    current = current.next;
            }

            return head;
        }

        /* Utility functions */

        /* Inserts a new Node at front of the list. */
        public ListNode push(int new_data)
        {
            /* 1 & 2: Allocate the Node &
                    Put in the data*/
            ListNode new_node = new ListNode(new_data);

            ListNode head = new ListNode();

            /* 3. Make next of new Node as head */
            new_node.next = head;

            /* 4. Move the head to point to new Node */
            head = new_node;

            return head;
        }

        /* Function to print linked list */
        public void printList(ListNode head)
        {
            ListNode temp = head;
            while (temp != null)
            {
                Console.Write(temp.val + " ");
                temp = temp.next;
            }
            Console.WriteLine();
        }

    }
}
