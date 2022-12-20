using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
using System.Data;
using InterwiewQuestions.LinkedLists;
using InterwiewQuestions.SortingQuestions;
using InterwiewQuestions.MediumQuestions;
using InterwiewQuestions.GraphTheoryQuestions;
using System.Linq;

namespace InterwiewQuestions
{
    public class Program
    {
        static void Main(string[] args)
        {

            //    //int[][] grid = new int[][]
            //    //{ 

            //    //    new int[]{0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0},
            //    //    new int[]{0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 0, 0, 0 },
            //    //    new int[]{0, 1, 1, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0 },
            //    //    new int[]{0, 1, 0, 0, 1, 1, 0, 0, 1, 0, 1, 0, 0 },
            //    //    new int[]{0, 1, 0, 0, 1, 1, 0, 0, 1, 1, 1, 0, 0 },
            //    //    new int[]{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0 },
            //    //    new int[]{0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 0, 0, 0 },
            //    //    new int[]{0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0 }

            //    //};

            //    int[][] grid = new int[][]
            //    {
            //        new int[]{ 0,0,0,0 },
            //        new int[]{ 1,0,1,0 },
            //        new int[]{ 0,1,1,0 },
            //        new int[]{ 0,0,0,0 }
            //    };

            //    var numberOfEnclaves = new NumberOfEnclaves();

            //    numberOfEnclaves.NumberOfEnclavesDepthFirstSearchApproach(grid);

            int[][] grid = new int[][]
                {
                    new int[]{ 1,2 },
                    new int[]{ 2,3 },
                    new int[]{ 4,2 }                    
                };

            var findCenterOfStarGraph = new FindCenterOfStarGraph();
            findCenterOfStarGraph.findCenter(grid);

        }
    }
}
