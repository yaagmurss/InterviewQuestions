using System;
using System.Collections.Generic;
using System.Text;

namespace InterwiewQuestions
{
    //Definition for singly-linked list.
    public class ListNode
    {
        public int element;
        public ListNode next;
        public ListNode(int e, ListNode n)
        {
            element = e;
            next = n;
        }
    }


    public class LinkedListQuestions
    {
        public ListNode Head;
        public ListNode Tail;
        public int Size;


        //You are given the heads of two sorted linked lists list1 and list2.
        //Merge the two lists in a one sorted list.The list should be made by splicing together the nodes of the first two lists.
        //Return the merged linked list.
        public ListNode MergeTwoListsWithLinkedList(ListNode list1, ListNode list2)
        {
            int i = 0;
            int size = 0;


            while (i < 5 )
            {
                    var newNode = new ListNode(Math.Min(list1.element, list2.element), null);
                    var secondNode = new ListNode(Math.Max(list1.element, list2.element), null);
                

                if (size == 0)
                {
                    Head = newNode;
                }
                else
                {
                    Tail.next = newNode;
                }

                Tail = newNode;
                Tail.next = secondNode;
                Tail = secondNode;
                i++;
                size++;

            }

            return Head;


        }
    }
}
