using System;
using InterwiewQuestions;


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

            Console.WriteLine("---------------------IsValid----------------------");
            //IsValid           
            
            Console.WriteLine(easyQuestions.IsValidParantheses("{[[]]}]"));



        }
    }
}
