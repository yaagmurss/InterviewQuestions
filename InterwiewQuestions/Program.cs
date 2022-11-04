using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
using System.Data;
using InterwiewQuestions.LinkedLists;

namespace InterwiewQuestions
{
    public class Program
    {
        static void Main(string[] args)
        {

            //RemoveFromLinkedList
            RemoveFromLinkedList llist = new RemoveFromLinkedList();
            llist.push(20);
            llist.push(13);
            llist.push(13);
            llist.push(11);
            llist.push(11);
            llist.push(11);

            Console.WriteLine("List before removal of duplicates");
            llist.printList(llist);

            llist.removeDuplicates(llist);
            

            Console.WriteLine("List after removal of elements");
            llist.printList();


        }
    }
}
