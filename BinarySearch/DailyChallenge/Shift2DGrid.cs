namespace DailyChallenge
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Shift2DGrid
    {
        public IList<IList<int>> ShiftGrid(int[][] grid, int k)
        {
            var m = grid.Length;
            var n = grid[0].Length;
            var result = new List<IList<int>>();
            var resultGrid = new int[m][];
            for (int i = 0; i < k; i++)
            {
                resultGrid = ShiftGrid(grid);
            }

            for (int i = 0; i < m; i++)
            {
                var list = new List<int>();
                for (int j = 0; j < n; j++)
                {
                    list.Add(resultGrid[i][j]);
                }

                result.Add(list);
            }

            return result;
        }
        public int[][] ShiftGrid(int[][] grid)
        {
            var m = grid.Length;
            var n = grid[0].Length;
            var newGrid = new int[m, n];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == m - 1 && j == n - 1)
                    {
                        newGrid[0, 0] = grid[i][j];
                    }
                    else if (j == n - 1)
                    { 
                        newGrid[i + 1, 0] = grid[i][j];
                    }
                    else
                    {
                        newGrid[i,j + 1] = grid[i][j];
                    }
                }
            }

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                        grid[i][j] = newGrid[i,j];
                }
            }

            return grid;
        }
    }
}
