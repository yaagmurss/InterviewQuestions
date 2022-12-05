using System;
using System.Xml;

namespace InterwiewQuestions.GraphTheoryQuestions
{
    /// <summary>
    /// You are given an m x n binary matrix grid. An island is a group of 1's (representing land) connected 4-directionally
    /// (horizontal or vertical.) You may assume all four edges of the grid are surrounded by water.
    /// The area of an island is the number of cells with a value 1 in the island.
    /// Return the maximum area of an island in grid.If there is no island, return 0.
    /// </summary>
    public class MaxAreaOfIsland
    {
        public int MaxAreaOfIslandDepthFirstSearchApproach(int[][] grid)
        {
            var m = grid.Length;
            var n = grid[0].Length;
            var ans = 0;

            for(var i=0; i<m; i++)
            {
                for(var j=0; j<n; j++)
                {
                    if (grid[i][j]==1)
                    {
                        var area = 0;
                        dfs(grid, area, i, j, m, n);
                        ans = Math.Max(area,ans);
                    }
                }
            }
            Console.WriteLine(ans);
            return ans;
        }


        public void  dfs(int[][] grid,int area, int i, int j, int m,int n)
        {
           
            if ( !(i < 0 || j < 0 || i >= m || j >= n) )
            {
                if (grid[i][j] == 1)
                {
                    area++;
                    grid[i][j] = -1;
                    dfs(grid, area, i + 1, j, m, n);
                    dfs(grid, area, i - 1, j, m, n);
                    dfs(grid, area, i, j + 1, m, n);
                    dfs(grid, area, i, j - 1, m, n);
                }
            }
           
        }
    }
}
