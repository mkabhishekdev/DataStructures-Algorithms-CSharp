using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProductCodingPractice.DynamicProgramming.YourTHINKINGWork
{
    /* Referred Approach
    1. So think of it like to reach the bottom right positon for the robot,
       think of one previous step reaching there.
    2. To reach that position there are only 2 ways possible:
       either from top to down from the adjacent node(i.e [i-1,j]) or from 
       right to left from the adjacent node [i.e i, j-1]
 ways to reach grid[i][j] = ways to reach grid[i-1][j] + ways to reach grid[i][j-1]
    */

    /* Any optimization later

    */

    /* Time complexity: O(m * n)
    Space complexity: O(m * n)
    */
    public class UniquePaths
    {
        public int UniquePathsImpl(int m, int n)
        {
            int[][] grid = new int[m][];

            for(int i = 0; i < m; i++)
            {
                grid[i] = new int[n];
            }

            for(int i = 0; i < m; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    if(i == 0 || j == 0)
                    {
                        grid[i][j] = 1;
                    }
                    else
                    {
                        grid[i][j] = grid[i-1][j] + grid[i][j-1];
                    }
                }
            }

            return grid[m-1][n-1];
        }
    }
}