using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterwiewQuestions.MediumQuestions
{
    public class MediumQuestion
    {
        /// <summary>
        /// You are given a positive integer num consisting only of digits 6 and 9.        
        /// Return the maximum number you can get by changing at most one digit(6 becomes 9, and 9 becomes 6).
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>

        public int maximum69Number(int num)
        {

            int numCopy = num;
            int indexSix = -1;
            int currDigit = 0;


            while (numCopy > 0)
            {

                if (numCopy % 10 == 6)
                    indexSix = currDigit;


                numCopy /= 10;
                currDigit++;
            }


            return indexSix == -1 ? num : num + 3 * (int)Math.Pow(10, indexSix);
        }

        public int Reverse(int x)
        {
            long res = 0;

            while (x != 0)
            {
                res = res * 10 + x % 10;
                x = x / 10;
            }

            if (res < Int32.MinValue || res > Int32.MaxValue)
            {
                return 0;
            }
            else
            {
                return Convert.ToInt32(res);
            }
        }
    }
        
}
