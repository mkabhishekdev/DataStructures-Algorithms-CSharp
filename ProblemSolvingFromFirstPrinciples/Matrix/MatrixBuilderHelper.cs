using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProblemSolvingFromFirstPrinciples.Matrix
{
    public static class MatrixBuilderHelper
    {
       public static void PrintMatrix(int[][] matrix)
       {
           for(int r = 0; r < matrix.Length; r++)
           {
               for(int c = 0; c < matrix[r].Length; c++)
               {
                   Console.Write(matrix[r][c] + " ");
               }
               Console.WriteLine();
           }
        }
    }
}

/*
Handy input format
 int[][] input =
        {
            new int[] {0,1,2,0},
            new int[] {3,4,5,2},
            new int[] {1,3,1,5}  
        };

        SetZeroes sz = new SetZeroes();
        sz.SetZeroesImpl(input);

*/