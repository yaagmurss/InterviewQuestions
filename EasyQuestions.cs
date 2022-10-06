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

    


    }
}
