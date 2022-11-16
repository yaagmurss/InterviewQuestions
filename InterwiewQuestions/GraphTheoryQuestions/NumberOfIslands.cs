using System;
using System.Collections.Generic;
using System.Text;

namespace InterwiewQuestions.GraphTheoryQuestions
{

    public class NumberOfIslands
    {
        /// <summary>
        /// Given an m x n 2D binary grid grid which represents a map of '1's (land) and '0's (water), 
        /// return the number of islands. 
        /// An island is surrounded by water and is formed by connecting adjacent lands horizontally or vertically.
        /// You may assume all four edges of the grid are all surrounded by water.
        /// </summary>
        public int NumIslands(char[][] grid)
        {
            int numberOfIslands = 0;
            int rows = grid.Length;
            int cols = grid[0].Length;  

            for(int i=0; i<rows; i++)
            {
                for(int j=0;j<cols; j++)
                {
                    if (grid[i][j]==1)
                    {
                        //Mark CurrentIsland
                        numberOfIslands++;
                    }
                }
            }



            return numberOfIslands;
        }

    }
}
