
using InterwiewQuestions.EasyQuestions;
using InterwiewQuestions.TreeQuesions;
using System;

namespace InterwiewQuestions
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 4,4 };

            var easyQuestions = new EasyQA();

            Console.WriteLine(easyQuestions.ContainsDuplicate(nums));


        }
    }
}
