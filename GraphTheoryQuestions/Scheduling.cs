namespace InterwiewQuestions.GraphTheoryQuestions
{
    public class Scheduling
    {
        public bool CanFinish(int numCourses, int[][] prerequisites)
        {
            if (numCourses == 1)
                return true;     

            var visited = new bool[numCourses];
            var onStack = new bool[numCourses];

            for (int i = 0; i < numCourses; ++i)
            {
                bool result = dfs(prerequisites, i, visited, onStack);

                if (!result)
                    return false;
            }
            return true;
        }
        private bool dfs(int[][] prerequisites, int num, bool[] visited, bool[] onStack)
        {
            if (onStack[num])
                return false;
            if (visited[num])
                return true;

            visited[num] = true;
            onStack[num] = true;           

            for (int c = 0; c < num; c++)
            {

                bool result = dfs(prerequisites, c, visited, onStack);

                if (!result)
                    return false;
            }

            onStack[num] = false;

            return true;
        }

    }
}

