using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProblemSolvingFromFirstPrinciples.Matrix.YourTHINKINGWork
{
      /*
       MY APPROACH (THINK/CODE - 45mins):
       1. Will keep a Dictionary to keep record of (i,j) combinations which equate to 0
            Dictionary<int,(int,int)> zeroMapping 
       2. Traverse through the matrix and find where the matrix[row][column] is 0
       3. Lets say we found matrix[rowFound][colFound] is the value in the matrix with 0
       4. Now pick each entry from Dictionary and do the below
       5. So make all the matrix[rowFound][column] to 0
       6. make all the matrix[row][columnFound] to 0
       7. return the resultant matrix
        */

        /*
        Any Optimization question while thinking through?/Any already learnt pattern you can remember?

        */

        /*
        Time Complexity: O(n2)
        Space Complexity: O(n)
        */
    public class SetZeroes
    {
        public void SetZeroesImpl(int[][] matrix)
        {
            int rowFound = -1, colFound = -1;

            Dictionary<int,(int,int)> zeroMapping = new Dictionary<int, (int, int)>();
            int counter = 0;

            for(int i = 0; i < matrix.Length; i++)
            {
                for(int j = 0; j < matrix[i].Length; j++)
                {
                    if(matrix[i][j] == 0)
                    {
                        zeroMapping.Add(counter,(i,j));
                        counter++;        
                    }
                }
            }

            while(counter > 0)
            {
                (rowFound,colFound) = zeroMapping[counter-1];
                
                for(int i = 0; i < matrix.Length; i++)
                {
                    for(int j = 0; j < matrix[i].Length; j++)
                    {
                        if(i == rowFound) 
                        {
                            matrix[i][j] = 0;
                        }
                        if(j == colFound)
                        {
                            matrix[i][j] = 0;
                        }
                    }
                }
                counter--;
            }

        }
    }
}

   // If all test cases not clearing or You did not arrive at the solution on own, PRACTICE DEBUGGING MUST
        /* FAILED APPROACH & WHY?

       
        */ 
        /* CODE:
        

        */