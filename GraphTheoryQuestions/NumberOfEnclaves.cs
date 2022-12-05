using System;
using System.Collections.Generic;
using System.Text;

namespace InterwiewQuestions.GraphTheoryQuestions
{
    /// <summary>
    /// You are given an m x n binary matrix grid, where 0 represents a sea cell and 1 represents a land cell.
    /// A move consists of walking from one land cell to another adjacent(4-directionally) land cell or walking off the boundary of the grid.
    /// Return the number of land cells in grid for which we cannot walk off the boundary of the grid in any number of moves.
    /// </summary>
    public class NumberOfEnclaves
    {
        public int NumberOfEnclavesDepthFirstSearchApproach(int[][] grid)
        {
            var m = grid.Length;
            var n = grid[0].Length;
            var ans = 0;

            for (var i = 0; i < m; i++)
            {
                for (var j = 0; j < n; j++)
                {
                    if (grid[i][j] == 1)
                    {
                        var area = 0;
                        dfs(grid, area, i, j, m, n);
                        ans = Math.Max(area, ans);
                    }
                }
            }
            Console.WriteLine(ans);
            return ans;
        }


        internal int dfs(int[][] grid, int area, int i, int j, int m, int n)
        {

            if (!(i < 0 || j < 0 || i >= m || j >= n))
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

            return area;

        }
    }
}
