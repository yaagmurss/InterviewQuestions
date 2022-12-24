using System;
using System.Collections.Generic;
using System.Text;

namespace InterwiewQuestions.GraphTheoryQuestions
{
    public class Scheduling
    {
        public static bool[] canFinish;
        public static bool[] courseVisited;

        private static bool CanFinish(int numCourses, int[][] prerequisites)
        {
            
            if (numCourses <= 0)
                return true;

            canFinish = new bool[numCourses];
            courseVisited = new bool[numCourses];

          
            for (int c = 0; c < numCourses; c++)
            {
                if (!canFinish[c])
                {
                    
                    if (!CanFinishCourse(c, prerequisites))
                        return false;
                }
            }

            return true;
        }

        private static bool CanFinishCourse(int c, int[][] prerequisites)
        {
            if (canFinish[c])
                return true;

            if (courseVisited[c])
                return false;
            else
                courseVisited[c] = true;

            for (int row = 0; row < prerequisites.Length; row++)
            {
                
                if (prerequisites[row][0] == c)
                {
                    
                    for (int col = 1; col < prerequisites[row].Length; col++)
                    {
                        if (!CanFinishCourse(prerequisites[row][col], prerequisites))
                        {
                            canFinish[c] = false;
                            return canFinish[c];
                        }
                    }
                }
            }

            canFinish[c] = true;
            return canFinish[c];
        }


    }
}

