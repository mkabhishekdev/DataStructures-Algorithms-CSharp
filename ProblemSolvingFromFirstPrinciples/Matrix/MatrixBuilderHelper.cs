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