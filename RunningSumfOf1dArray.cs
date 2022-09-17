using System;
using System.Collections.Generic;
using System.Text;

namespace InterwiewQuestions
{
    public class RunningSumfOf1dArray
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

       
    }
}
