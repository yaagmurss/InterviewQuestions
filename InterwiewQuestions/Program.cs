using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
using System.Data;
using InterwiewQuestions.LinkedLists;
using InterwiewQuestions.SortingQuestions;

namespace InterwiewQuestions
{
    public class Program
    {
        static void Main(string[] args)
        {
            var sortingArrayQuestions = new SortingArrayQuestions();

            var nums1 = new int[] { -1, 0, 0, 3, 3, 3, 0, 0, 0 };
            var nums2 = new int[] {1, 2, 2};

            
            sortingArrayQuestions.Merge(nums1,6,nums2,3);

            foreach (var element in nums1)
            {
                Console.Write(element);
            }


        }
    }
}
