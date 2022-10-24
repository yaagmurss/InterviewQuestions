﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
using System.Data;

namespace InterwiewQuestions
{
    public class Program
    {
        static void Main(string[] args)
        {
            var easyQuestions = new EasyQuestions();

            Console.WriteLine("---------------------RunningArray----------------------");
            //RunninArray
            int[] nums = new int[] { 1, 2, 3, 4, 5 };
            easyQuestions.RunningSum(nums);

            Console.WriteLine("---------------------OrderFromLongestToShortest----------------------");
            //OrderFromLongestToShortest
            var words = new string[] { "kkkkkkk", "bb", "a", "ccc" };
            easyQuestions.OrderFromLongestToShortest(words);


            Console.WriteLine("---------------------TwoSum----------------------");
            //TwoSum
            nums = new int[] { 1, 2, 3, 4, 5 };
            easyQuestions.TwoSum(nums, 3);

            Console.WriteLine("---------------------PalindromeNumber----------------------");
            //PalindromeNumber

            Console.WriteLine(easyQuestions.IsPalindrome(1000021));
            Console.WriteLine(easyQuestions.IsPalindromeBetterWay(1231321));

            Console.WriteLine("---------------------RomanNumber----------------------");
            //RomanNumber

            Console.WriteLine("55 - " + easyQuestions.RomanToInt("LV"));
            Console.WriteLine("56 - " + easyQuestions.RomanToInt("LVI"));
            Console.WriteLine("60 - " + easyQuestions.RomanToInt("LX"));
            Console.WriteLine("65 - " + easyQuestions.RomanToInt("LXV"));
            Console.WriteLine("75 - " + easyQuestions.RomanToInt("LXXV"));
            Console.WriteLine("85 - " + easyQuestions.RomanToInt("LXXXV"));
            Console.WriteLine("95 - " + easyQuestions.RomanToInt("XCV"));
            Console.WriteLine("99 - " + easyQuestions.RomanToInt("XCIX"));
            Console.WriteLine("100 - " + easyQuestions.RomanToInt("C"));

            Console.WriteLine("---------------------LongestCommonPrefix----------------------");
            //LongestCommonPrefix

            var stringArray = new string[] {"flower", "flow", "flight"};

            Console.WriteLine(easyQuestions.LongestCommonPrefix(stringArray));

            Console.WriteLine("---------------------IsValidParantheses----------------------");
            //IsValidParantheses           

            Console.WriteLine(easyQuestions.IsValidParantheses("{[[]]}]"));
            Console.WriteLine(easyQuestions.IsValidParanthesesBetterWay("{[[]]}"));

            Console.WriteLine("---------------------MergeTwoLists----------------------");
            //MergeTwoLists

            var list1 = new List<int>{1,2,3};
            var list2 = new List<int>{3,4,5};

            Console.WriteLine(easyQuestions.MergeTwoLists(list1, list2));

            Console.WriteLine("---------------------RemoveDuplicatesfromSortedArray----------------------");

            var numbers = new int[] { 1,1,5,8,8,9 };
            //  [1,1,2] ==> 2
            //  [0,0,1,1,1,2,2,3,3,4] ==> 5

            Console.WriteLine(easyQuestions.RemoveDuplicates(numbers));



        }
    }
}