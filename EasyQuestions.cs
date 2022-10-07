using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace InterwiewQuestions
{
    public class EasyQuestions
    {
        
        public int[] RunningSum(int[] nums)
        {
            int counter = 0;
            int index = 0;

            int[] runningArray = new int[nums.Length];

            foreach (var n in nums)
            {
                int sum = 0;
                counter = index;

                while (counter>=0)
                {
                    
                    sum += nums[counter];
                    counter -= 1;
                }
                runningArray[index] = sum ;
                index += 1;

            }           



            foreach(var n in runningArray)
            {
                Console.WriteLine(n);
            }

            return runningArray;
        }        

        public IEnumerable<string> OrderFromLongestToShortest(IEnumerable<string> words)
        {
            // Using LINQ, implement the OrderFromLongestToShortest method, which takes a collection of strings,
            // And returns those strings ordered from longest to shortest.

            //    For example, for { "bb", "a", "ccc"}
            //    The result should be { "ccc", "bb", "a"}                           
           
            List<string> strList = words.OrderBy(key=>key).ToList();

            foreach (var str in strList)
            {
                Console.WriteLine(str);
            }

            return strList;
        }

        public int[] TwoSum(int[] nums, int target)
        {
            int element1 = 0; 
            int element2 = 0;

            foreach (var i in nums)
            {                
                foreach(var j in nums)
                {                   
                    if (i != j)
                    { 
                        if( i + j == target)
                        {
                            element1 = i;
                            element2 = j;
                            
                        }
                    }
                }
            }
            var twoSum = new int[2]{ nums[element1], nums[element2]};

            Console.WriteLine(twoSum[0].ToString(),twoSum[1].ToString());
            return twoSum;
        }

        public bool IsPalindrome(int x)
        {
        //Runtime: 101 ms
        //Memory Usage: 29.4 MB

        //Given an integer x, return true if x is palindrome integer.
        //An integer is a palindrome when it reads the same backward as forward.
        //For example, 121 is a palindrome while 123 is not.
        //Could you solve it without converting the integer to a string?

        var listOfInteger = new List<int>();
            bool isIntegerPalindrome = false;

            while (x >= 0)
            {
                if (x == 0)
                {
                    isIntegerPalindrome = true;
                    break;
                }
                else
                {
                    listOfInteger.Add(x % 10);
                    x = x / 10;
                }                
            }

            for(int i=0; i<listOfInteger.Count; i++)
            {
                if (listOfInteger[i] == listOfInteger[listOfInteger.Count - (i + 1)])
                {
                    isIntegerPalindrome = true;
                }
                else
                {
                    isIntegerPalindrome = false;
                    break;
                }
            }         
            return isIntegerPalindrome;            
        }

        public bool IsPalindromeBetterWay(int x)
        {
            //Runtime: 91 ms, faster than 32.86 % of C# online submissions for Palindrome Number.
            //Memory Usage: 28.5 MB, less than 60.81 % of C# online submissions for Palindrome Number.

            if (x < 0 || x % 10 == 0) { return false; }
            if (x == 0 ) { return true; }

            int reversedNum = 0;
            while(x > reversedNum)
            {
                reversedNum = reversedNum * 10 + (x % 10);
                x /= 10;
            }
            return x == reversedNum || x == reversedNum/10;                
        }

        public int RomanToInt(string s)
        {

            //Roman numerals are represented by seven different symbols: I, V, X, L, C, D and M.

            //Symbol Value
            //I             1
            //V             5
            //X             10
            //L             50
            //C             100
            //D             500
            //M             1000
            //For example, 2 is written as II in Roman numeral, just two ones added together. 12 is written as XII, which is simply X + II.The number 27 is written as XXVII, which is XX + V + II.

            //Roman numerals are usually written largest to smallest from left to right.However, the numeral for four is not IIII.Instead, the number four is written as IV.Because the one is before the five we subtract it making four.The same principle applies to the number nine, which is written as IX.There are six instances where subtraction is used:


            //I can be placed before V(5) and X(10) to make 4 and 9.
            //X can be placed before L(50) and C(100) to make 40 and 90.
            //C can be placed before D(500) and M(1000) to make 400 and 900.
            //Given a roman numeral, convert it to an integer.


            int returnedNum = 0;
            char[] chars = s.ToCharArray();
            var dictRoman = new Dictionary<string, int>();
            dictRoman.Add("I", 1);
            dictRoman.Add("V", 5);
            dictRoman.Add("X", 10);
            dictRoman.Add("L", 50);
            dictRoman.Add("C", 100);
            dictRoman.Add("D", 500);
            dictRoman.Add("M", 1000);

            var xxx = s.LastIndexOf("X");
            var yyy = s.LastIndexOf("I");

            if (s.Contains("I") && (s.IndexOf("I") < s.IndexOf("V") || s.IndexOf("I") < s.IndexOf("X")))
            {
                dictRoman["I"] = -1;
            }
            if (s.Contains("X") && s.IndexOf("X") < s.IndexOf("L") || s.IndexOf("X") < s.IndexOf("C"))
            {
                dictRoman["X"] = -10;
            }


            foreach (var c in chars)
            {                
                returnedNum = returnedNum + dictRoman[c.ToString()];
            }



            return returnedNum;



        }

    


    }
}
