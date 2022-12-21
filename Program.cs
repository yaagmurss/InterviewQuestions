using System;
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

            int[][] edges = new int[][]
                {
                    new int[]{ 0,1 },
                    new int[]{ 1,2 },
                    new int[]{ 2,0 }                    
                };
            var n = 5;
            var source = 0;
            var destination = 2;

            var findPath = new FindPath();
            Console.WriteLine(findPath.ValidPath(n, edges, source, destination)); 


        }
    }
}
