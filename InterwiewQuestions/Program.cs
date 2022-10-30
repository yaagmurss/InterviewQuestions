using System;
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

            var testCase1 = new int[] { 1, 1, 2, 2, 3, 4, 5, 5 };
            var testCase2 = new int[] { 1, 1, 2, 2, 3 };
            var testCase3 = new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
            var testCase4 = new int[] {  };
            var testCase5 = new int[] { 1 };
            var testCase6 = new int[] {1, 1,  2 };

            //Console.WriteLine(easyQuestions.RemoveDuplicates(numbers));
            if (easyQuestions.RemoveDublicatesBetterWay(testCase1) == 5) { Console.WriteLine("testCase1 : PASS :)"); } else  { Console.WriteLine("testCase1 : FAIL"); }
            if (easyQuestions.RemoveDublicatesBetterWay(testCase2) == 3) { Console.WriteLine("testCase2 : PASS :)"); } else { Console.WriteLine("testCase2 : FAIL"); }
            if (easyQuestions.RemoveDublicatesBetterWay(testCase3) == 5) { Console.WriteLine("testCase3 : PASS :)"); } else { Console.WriteLine("testCase3 : FAIL"); }
            if (easyQuestions.RemoveDublicatesBetterWay(testCase4) == 0) { Console.WriteLine("testCase4 : PASS :)"); } else { Console.WriteLine("testCase4 : FAIL"); }
            if (easyQuestions.RemoveDublicatesBetterWay(testCase5) == 1) { Console.WriteLine("testCase5 : PASS :)"); } else { Console.WriteLine("testCase5 : FAIL"); }
            if (easyQuestions.RemoveDublicatesBetterWay(testCase6) == 2) { Console.WriteLine("testCase6 : PASS :)"); } else { Console.WriteLine("testCase6 : FAIL"); }

            Console.WriteLine("---------------------RemoveElement----------------------");

            var testCase1ForRemoveElement = new int[] { 0, 1, 2, 2, 3, 0, 4, 2 };
            var testCase2ForRemoveElement = new int[] { 1, 1, 2, 2, 3 };
            var testCase3ForRemoveElement = new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
            var testCase4ForRemoveElement = new int[] { };
            var testCase5ForRemoveElement = new int[] { 1 };
            var testCase6ForRemoveElement = new int[] { 1, 1, 2 };

            //Console.WriteLine(easyQuestions.RemoveDuplicates(numbers));
            if (easyQuestions.RemoveElement(testCase1ForRemoveElement,2) == 5) { Console.WriteLine("testCase1 : PASS :)"); } else { Console.WriteLine("testCase1 : FAIL"); }
            if (easyQuestions.RemoveElement(testCase2ForRemoveElement,2) == 3) { Console.WriteLine("testCase2 : PASS :)"); } else { Console.WriteLine("testCase2 : FAIL"); }
            if (easyQuestions.RemoveElement(testCase3ForRemoveElement,1) == 7) { Console.WriteLine("testCase3 : PASS :)"); } else { Console.WriteLine("testCase3 : FAIL"); }
            if (easyQuestions.RemoveElement(testCase4ForRemoveElement,5) == 0) { Console.WriteLine("testCase4 : PASS :)"); } else { Console.WriteLine("testCase4 : FAIL"); }
            if (easyQuestions.RemoveElement(testCase5ForRemoveElement,1) == 0) { Console.WriteLine("testCase5 : PASS :)"); } else { Console.WriteLine("testCase5 : FAIL"); }
            if (easyQuestions.RemoveElement(testCase6ForRemoveElement,1) == 1) { Console.WriteLine("testCase6 : PASS :)"); } else { Console.WriteLine("testCase6 : FAIL"); }


            Console.WriteLine("---------------------SearchInsertPosition----------------------");

            var binaySearchQuestions = new BinaySearchQuestions();

            var testCase1ForSearchInsertPosition = new int[] { 1, 3, 5, 6 };
            var testCase2ForSearchInsertPosition = new int[] { 1, 3, 5, 6 };
            var testCase3ForSearchInsertPosition = new int[] { 1, 3, 5, 6 };
            var testCase4ForSearchInsertPosition = new int[] { };
            var testCase5ForSearchInsertPosition = new int[] { 1 };
            var testCase6ForSearchInsertPosition = new int[] { 1, 2, 3 };

            //Console.WriteLine(easyQuestions.RemoveDuplicates(numbers));
            if (binaySearchQuestions.SearchInsertPosition(testCase1ForSearchInsertPosition, 5) == 2) { Console.WriteLine("testCase1 : PASS :)"); } else { Console.WriteLine("testCase1 : FAIL"); }
            if (binaySearchQuestions.SearchInsertPosition(testCase2ForSearchInsertPosition, 2) == 1) { Console.WriteLine("testCase2 : PASS :)"); } else { Console.WriteLine("testCase2 : FAIL"); }
            if (binaySearchQuestions.SearchInsertPosition(testCase3ForSearchInsertPosition, 7) == 4) { Console.WriteLine("testCase3 : PASS :)"); } else { Console.WriteLine("testCase3 : FAIL"); }
            if (binaySearchQuestions.SearchInsertPosition(testCase4ForSearchInsertPosition, 5) == 0) { Console.WriteLine("testCase4 : PASS :)"); } else { Console.WriteLine("testCase4 : FAIL"); }
            if (binaySearchQuestions.SearchInsertPosition(testCase5ForSearchInsertPosition, 2) == 1) { Console.WriteLine("testCase5 : PASS :)"); } else { Console.WriteLine("testCase5 : FAIL"); }
            if (binaySearchQuestions.SearchInsertPosition(testCase6ForSearchInsertPosition, 0) == 0) { Console.WriteLine("testCase6 : PASS :)"); } else { Console.WriteLine("testCase6 : FAIL"); }

            Console.WriteLine("---------------------LengthOfLastWord----------------------");

            var stringOperationsQuestions = new StringOperationsQuestions();

            var testCase1ForStringOperationsQuestions = "Hello World";
            var testCase2ForStringOperationsQuestions = "   fly me   to   the moon  ";
            var testCase3ForStringOperationsQuestions = "luffy is still joyboy";
            var testCase4ForStringOperationsQuestions = "     ";
            var testCase5ForStringOperationsQuestions = "a";
            var testCase6ForStringOperationsQuestions = "aaa";

            //Console.WriteLine(easyQuestions.RemoveDuplicates(numbers));
            if (stringOperationsQuestions.LengthOfLastWord(testCase1ForStringOperationsQuestions) == 5) { Console.WriteLine("testCase1 : PASS :)"); } else { Console.WriteLine("testCase1 : FAIL"); }
            if (stringOperationsQuestions.LengthOfLastWord(testCase2ForStringOperationsQuestions) == 4) { Console.WriteLine("testCase2 : PASS :)"); } else { Console.WriteLine("testCase2 : FAIL"); }
            if (stringOperationsQuestions.LengthOfLastWord(testCase3ForStringOperationsQuestions) == 6) { Console.WriteLine("testCase3 : PASS :)"); } else { Console.WriteLine("testCase3 : FAIL"); }
            if (stringOperationsQuestions.LengthOfLastWord(testCase4ForStringOperationsQuestions) == 0) { Console.WriteLine("testCase4 : PASS :)"); } else { Console.WriteLine("testCase4 : FAIL"); }
            if (stringOperationsQuestions.LengthOfLastWord(testCase5ForStringOperationsQuestions) == 1) { Console.WriteLine("testCase5 : PASS :)"); } else { Console.WriteLine("testCase5 : FAIL"); }
            if (stringOperationsQuestions.LengthOfLastWord(testCase6ForStringOperationsQuestions) == 3) { Console.WriteLine("testCase6 : PASS :)"); } else { Console.WriteLine("testCase6 : FAIL"); }



        }
    }
}
