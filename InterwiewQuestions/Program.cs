using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
using System.Data;
using InterwiewQuestions.LinkedLists;
using InterwiewQuestions.SortingQuestions;
using InterwiewQuestions.MediumQuestions;
using InterwiewQuestions.GraphTheoryQuestions;

namespace InterwiewQuestions
{
    public class Program
    {
        static void Main(string[] args)
        {
            var depthFirst = new DepthFirstSearch();

            //A jagged array is sometimes called an "array of arrays." 
            depthFirst.removeStones(new int[][]{
                                                new int[] { 1, 3, 5, 7, 9 },
                                                new int[] { 0, 2, 4, 6 },
                                                new int[] { 11, 22 }
                                                });





        }
    }
}
