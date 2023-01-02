using System.Collections.Generic;
using System;
using System.Runtime.InteropServices;


namespace InterwiewQuestions.StringOperations
{
    public class StringOperationsQuestions
    {
        public int LengthOfLastWord(string s)
        {

            bool isContainsAnyLetter = false;

            string[] sArray = s.Split(' ');

            var sArray2 = new List<string>();

            foreach (string str in sArray)
            {
                if (str != "")
                {
                    sArray2.Add(str);
                    isContainsAnyLetter = true;
                }
            }


            if (isContainsAnyLetter)
            {
                return sArray2[sArray2.Count - 1].Length;
            }
            else
            {
                return 0;
            }


        }

        /// <summary>
        /// We define the usage of capitals in a word to be right when one of the following cases holds:
        /// All letters in this word are capitals, like "USA".
        /// All letters in this word are not capitals, like "leetcode".
        /// Only the first letter in this word is capital, like "Google".
        /// Given a string word, return true if the usage of capitals in it is right.
        /// </summary>
        /// <param name="word"></param>
        /// <returns></returns>
        public bool DetectCapitalUse(string word)
        {
            bool islower = true, isupper = true;

            for (int i = 1; i < word.Length; i++)
            {
                if (Char.IsLower(word[i]))
                {
                    isupper = false;
                }
                else
                {
                    islower = false;
                }

            }
            return islower || (isupper && Char.IsUpper(word[0]));



        }
    }

    
}
