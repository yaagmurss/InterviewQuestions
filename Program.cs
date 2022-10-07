using System;
using InterwiewQuestions;


namespace InterwiewQuestions
{
    public class Program
    {
        static void Main(string[] args)
        {
            var easyQuestions = new EasyQuestions();

            Console.WriteLine("---------------------RunninArray----------------------");
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

            Console.WriteLine("3 - " + easyQuestions.RomanToInt("III"));
            Console.WriteLine("4 - " + easyQuestions.RomanToInt("IV"));
            Console.WriteLine("5 - " + easyQuestions.RomanToInt("V"));
            Console.WriteLine("6 - " + easyQuestions.RomanToInt("VI"));
            Console.WriteLine("7 - " + easyQuestions.RomanToInt("VII"));
            Console.WriteLine("8 - " + easyQuestions.RomanToInt("VIII"));
            Console.WriteLine("9 - " + easyQuestions.RomanToInt("IX"));
            Console.WriteLine("10 - " + easyQuestions.RomanToInt("X"));
            Console.WriteLine("11 - " + easyQuestions.RomanToInt("XI"));
            Console.WriteLine("12 - " + easyQuestions.RomanToInt("XII"));
            Console.WriteLine("13 - " + easyQuestions.RomanToInt("XIII"));
            Console.WriteLine("14 - " + easyQuestions.RomanToInt("XIV"));
            Console.WriteLine("15 - " + easyQuestions.RomanToInt("XV"));
            Console.WriteLine("16 - " + easyQuestions.RomanToInt("XVI"));
            Console.WriteLine("17 - " + easyQuestions.RomanToInt("XVII"));
            Console.WriteLine("18 - " + easyQuestions.RomanToInt("XVIII"));


            Console.WriteLine("19 - " + easyQuestions.RomanToInt("XIX"));


            Console.WriteLine("20 - " + easyQuestions.RomanToInt("XX"));
            Console.WriteLine("21 - " + easyQuestions.RomanToInt("XXI"));

            Console.WriteLine("30 - " + easyQuestions.RomanToInt("XXX"));
            Console.WriteLine("30 - " + easyQuestions.RomanToInt("XL"));
            Console.WriteLine("45 - " + easyQuestions.RomanToInt("XLV"));
            Console.WriteLine("46 - " + easyQuestions.RomanToInt("XLVI"));
            Console.WriteLine("47 - " + easyQuestions.RomanToInt("XLVII"));
            Console.WriteLine("48 - " + easyQuestions.RomanToInt("XLVIII"));


            Console.WriteLine("49 - " + easyQuestions.RomanToInt("XLIX"));


            Console.WriteLine("50 - " + easyQuestions.RomanToInt("L"));
            Console.WriteLine("51 - " + easyQuestions.RomanToInt("LI"));
            Console.WriteLine("52 - " + easyQuestions.RomanToInt("LII"));
            Console.WriteLine("53 - " + easyQuestions.RomanToInt("LIII"));
            Console.WriteLine("54 - " + easyQuestions.RomanToInt("LIV"));
            Console.WriteLine("55 - " + easyQuestions.RomanToInt("LV"));
            Console.WriteLine("56 - " + easyQuestions.RomanToInt("LVI"));
            Console.WriteLine("60 - " + easyQuestions.RomanToInt("LX"));
            Console.WriteLine("65 - " + easyQuestions.RomanToInt("LXV"));
            Console.WriteLine("75 - " + easyQuestions.RomanToInt("LXXV"));
            Console.WriteLine("85 - " + easyQuestions.RomanToInt("LXXXV"));
            Console.WriteLine("95 - " + easyQuestions.RomanToInt("XCV"));


            Console.WriteLine("99 - " + easyQuestions.RomanToInt("XCIX"));


            Console.WriteLine("100 - " + easyQuestions.RomanToInt("C"));
        }
    }
}
