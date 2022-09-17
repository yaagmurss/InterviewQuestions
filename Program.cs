using System;
using InterwiewQuestions;


namespace InterwiewQuestions
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 1, 2, 3, 4, 5 };

            var runningSumfOfArray = new RunningSumfOf1dArray();
            runningSumfOfArray.RunningSum(nums);
        }
    }
}
