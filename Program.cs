
using InterwiewQuestions.EasyQuestions;
using InterwiewQuestions.TreeQuesions;
using System;

namespace InterwiewQuestions
{
    public class Program
    {
        static void Main(string[] args)
        {
            var easyQuestions = new EasyQA();
            //Console.WriteLine(easyQuestions.isPowerOfTwoMethod2(8));

            var nums = new int[4] { 1, 2, 3, 1 };
            var k = 3;


            Console.WriteLine(easyQuestions.ContainsNearbyDuplicate(nums, k ));
        }


    }
}
