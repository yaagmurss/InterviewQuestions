using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace InterwiewQuestions.EasyQuestions
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

                while (counter >= 0)
                {

                    sum += nums[counter];
                    counter -= 1;
                }
                runningArray[index] = sum;
                index += 1;

            }



            foreach (var n in runningArray)
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

            List<string> strList = words.OrderBy(key => key).ToList();

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
                foreach (var j in nums)
                {
                    if (i != j)
                    {
                        if (i + j == target)
                        {
                            element1 = i;
                            element2 = j;

                        }
                    }
                }
            }
            var twoSum = new int[2] { nums[element1], nums[element2] };

            Console.WriteLine(twoSum[0].ToString(), twoSum[1].ToString());
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

            for (int i = 0; i < listOfInteger.Count; i++)
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
            if (x == 0) { return true; }

            int reversedNum = 0;
            while (x > reversedNum)
            {
                reversedNum = reversedNum * 10 + x % 10;
                x /= 10;
            }
            return x == reversedNum || x == reversedNum / 10;
        }

        public int RomanToInt(string s)
        {
            Dictionary<char, int> RomanMap = new Dictionary<char, int>()
            {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}
            };

            int number = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (i + 1 < s.Length && RomanMap[s[i]] < RomanMap[s[i + 1]])
                {
                    number -= RomanMap[s[i]];
                }
                else
                {
                    number += RomanMap[s[i]];
                }
            }
            return number;
        }

        public string LongestCommonPrefix(string[] strs)
        {
            if (strs.Length == 0) return "";
            string prefix = strs[0];
            for (int i = 1; i < strs.Length; i++)
                while (strs[i].IndexOf(prefix) != 0)
                {
                    prefix = prefix.Substring(0, prefix.Length - 1);
                    if (prefix == "") return "";
                }
            return prefix;
        }

        public bool IsValidParantheses(string s)
        {
            //Runtime    Memory
            //256 ms     39.1 MB

            while (s.Contains("{}") || s.Contains("()") || s.Contains("[]"))
            {
                s = s.Replace("{}", "");
                s = s.Replace("[]", "");
                s = s.Replace("()", "");
            }

            if (s == "")
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool IsValidParanthesesBetterWay(string s)
        {
            //  Runtime: 105 ms, faster than 70.84 % 
            //  Memory Usage: 36.9 MB, less than 32.66 % 

            if (string.IsNullOrEmpty(s))
                return true;

            Stack<char> brackets = new Stack<char>();

            foreach (var c in s)
            {
                if (c == '[' || c == '{' || c == '(')
                    brackets.Push(c);
                else if (c == ']' || c == '}' || c == ')')
                {
                    // Too many closing brackets, e.g. (123))
                    if (brackets.Count <= 0)
                        return false;

                    char open = brackets.Pop();

                    // Inconsistent brackets, e.g. (123]
                    if (c == '}' && open != '{' ||
                        c == ')' && open != '(' ||
                        c == ']' && open != '[')
                        return false;
                }
            }

            // Too many opening brackets, e.g. ((123) 
            if (brackets.Count > 0)
                return false;

            return true;
        }

        public List<int> MergeTwoLists(List<int> list1, List<int> list2)
        {
            var outputList = new List<int>();
            var lenght = Math.Max(list1.Count, list2.Count);

            if (lenght == 0)
            {
                return outputList;
            }

            for (var i = 0; i < lenght; i++)
            {
                try
                {
                    if (list1[i] < list2[i])
                    {
                        outputList.Add(list1[i]);
                        outputList.Add(list2[i]);
                    }
                    else
                    {
                        outputList.Add(list2[i]);
                        outputList.Add(list1[i]);
                    }
                }
                catch
                {
                    Console.WriteLine("you got cathed");
                }
            }

            foreach (var element in outputList)
            {
                Console.WriteLine(element);
            }

            return outputList;

        }

        public int RemoveDuplicates(int[] nums)
        {
            int t = 0;
            int firstDublicate = 0;
            while (t < nums.Length - 1)
            {

                var firstElement = nums[t];
                var secondElement = nums[t + 1];
                t++;

                if (firstElement == secondElement)
                {
                    firstDublicate = firstElement;
                    break;
                }
            }



            int j = 0;
            while (j < nums.Length - 1)
            {

                var firstElement = nums[j];
                var secondElement = nums[j + 1];


                if (firstElement == secondElement)
                {

                    int i = Array.FindIndex(nums, w => w == firstElement);

                    while (i < nums.Length - 1)
                    {
                        nums[i] = nums[i + 1];
                        i++;
                    }

                    nums[nums.Length - 1] = firstElement;

                }
                else
                {
                    j++;
                }

            }



            int k = 0;
            foreach (var n in nums)
            {
                k++;

                if (n == firstDublicate & k > 1)
                {
                    break;
                }
            }






            return k - 1;
        }

        public int RemoveDublicatesBetterWay(int[] nums)
        {
            int count = 0;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] == nums[i + 1])
                {
                    nums[i] = int.MaxValue;
                    count = count + 1;
                }
            }

            Array.Sort(nums);
            return nums.Length - count;
        }

        public int RemoveElement(int[] nums, int val)
        {
            ////// <summary>
            /// Given an integer array nums and an integer val, remove all occurrences of val in nums in-place. The relative order of the elements may be changed.
            /// Since it is impossible to change the length of the array in some languages, 
            /// You must instead have the result be placed in the first part of the array nums.More formally, if there are k elements after removing the duplicates, 
            /// Then the first k elements of nums should hold the final result. It does not matter what you leave beyond the first k elements.
            /// Return k after placing the final result in the first k slots of nums.
            /// Do not allocate extra space for another array. You must do this by modifying the input array in-place with O(1) extra memory.
            /// </summary>

            int k = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == val)
                {
                    nums[i] = int.MaxValue;
                    k++;
                }
            }


            Array.Sort(nums);
            return nums.Length - k;
        }

        public int[] PlusOne(int[] digits)
        {
            int n = digits.Length;
            for (int i = n - 1; i >= 0; i--)
            {
                if (digits[i] < 9)
                {
                    digits[i]++;
                    return digits;
                }
                digits[i] = 0;
            }
            int[] newNumber = new int[n + 1];
            newNumber[0] = 1;

            return newNumber;
        }


        public string AddBinary(string a, string b)
        {


            // This function adds two 
            // binary strings and return
            // result as a third string


            // Initialize result
            string result = "";

            // Initialize digit sum
            int s = 0;

            // Traverse both strings starting 
            // from last characters
            int i = a.Length - 1, j = b.Length - 1;
            while (i >= 0 || j >= 0 || s == 1)
            {

                // Comput sum of last 
                // digits and carry
                s += i >= 0 ? a[i] - '0' : 0;
                s += j >= 0 ? b[j] - '0' : 0;

                // If current digit sum is 
                // 1 or 3, add 1 to result
                result = (char)(s % 2 + '0') + result;

                // Compute carry
                s /= 2;

                // Move to next digits
                i--; j--;
            }
            return result;
        }


    }


}
