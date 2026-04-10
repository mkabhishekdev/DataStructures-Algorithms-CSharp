using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterviewLabCodeRepo.Interview
{
   

    /* any optimization later
    - helperMethod()to check if it is a island? - No, for DFS we need
    */

    /* time complexity: O(row*col)
    space complexity: O(1)
    */
    public class NumberOfIslands
    {
        public int NumIslands(char[][] grid)
        {
            int islandCount = 0;

            for(int i = 0; i < grid.Length; i++)
            {
                for(int j = 0; j < grid[i].Length;j++)
                {
                    if(grid[i][j] == '1')
                    {
                        islandCount++;
                        DFS(grid, i, j);     
                    }
                }
            }

            return islandCount;
        }

        private void DFS(char[][] grid, int i, int j)
        {
            if(i < 0 || j < 0 || i >= grid.Length || j >= grid[0].Length || grid[i][j] == '0')
            {
                return;
            }

            //mark visited
            grid[i][j] = '0';

            // explore in all 4 directions
            DFS(grid,i,j+1);
            DFS(grid,i,j-1);
            DFS(grid,i+1,j);
            DFS(grid,i-1,j);
        }

    }
}

 /* Failed approach
    1. traverse through the jagged array, check for char[i][j] = 1
    2. when you find land(i.e 1), check if (i+1)and(i-1) is water (i.e 0)
    3. Or check if (j+1) and (j-2) is water
    4. If any of them are true -> than the element is an island, save the count of the islands
       in a variable
    5. if they return false -> keep iterating over the jagged array
    */