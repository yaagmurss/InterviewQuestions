using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
using System.Data;
using InterwiewQuestions.LinkedLists;
using InterwiewQuestions.SortingQuestions;
using InterwiewQuestions.MediumQuestions;

namespace InterwiewQuestions
{
    public class Program
    {
        static void Main(string[] args)
        {
            //// SortingArrayQuestions
            //var sortingArrayQuestions = new SortingArrayQuestions();

            //var nums1 = new int[] { -1, 0, 0, 3, 3, 3, 0, 0, 0 };
            //var nums2 = new int[] {1, 2, 2};
            
            //sortingArrayQuestions.Merge(nums1,6,nums2,3);

            //foreach (var element in nums1)
            //{
            //    Console.Write(element);
            //}

            // MediumQuestions

            var mediumQuestions = new MediumQuestion();

            Console.WriteLine(mediumQuestions.maximum69Number(9669));

            Console.WriteLine(mediumQuestions.Reverse(123));





        }
    }
}
