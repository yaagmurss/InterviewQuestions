using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;

namespace InterwiewQuestions
{
    internal class StringOperationsQuestions
    {
        public int LengthOfLastWord(string s)
        {

            bool isContainsAnyLetter = false; 

            String[] sArray = s.Split(' ');

            var sArray2 =new List<string>();

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
    }
}
