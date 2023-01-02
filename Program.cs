using InterwiewQuestions.StringOperations;
using InterwiewQuestions.GraphTheoryQuestions;

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

            //int[][] prerequisites = new int[][]
            //    {
            //        new int[]{ 1,3 },
            //        new int[]{ 2,3 },
            //        new int[]{ 3,1 }
            //    };

            //var schedulingProblems = new Scheduling();

            //schedulingProblems.CanFinish(3, prerequisites) ;


            // DetectCapitalUse

            //Input: word = "USA"
            //Output: true


            //Input: word = "FlaG"
            //Output: false
            var stringOperationsQuestions = new StringOperationsQuestions();

            stringOperationsQuestions.DetectCapitalUse("GoogLe");

        }
    }
}
