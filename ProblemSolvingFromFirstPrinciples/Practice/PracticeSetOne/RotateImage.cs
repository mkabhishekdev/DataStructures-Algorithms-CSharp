using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProblemSolvingFromFirstPrinciples.Practice.PracticeSetOne
{
    public class RotateImage
    {
        public int[][] RotateImageImpl(int[][] matrix)
        {
            int n = matrix.Length;

            for(int i = 0; i < (n+1)/2; i++)
            {
                for(int j = 0; j < n/2; j++)
                {
                    //start 4 way swap
                    int temp = matrix[n-1-j][i];

                    matrix[n-1-j][i] = matrix[n-1-i][n-j-1];

                    matrix[n-1-i][n-j-1] = matrix[j][n-1-i];

                    matrix[j][n-1-i] = matrix[i][j];

                    matrix[i][j] = temp;
                }
            }

            return matrix;
        }
    }
}