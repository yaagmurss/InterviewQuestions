
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
            Console.WriteLine(easyQuestions.isPowerOfTwoMethod2(8));
        }
    }
}
