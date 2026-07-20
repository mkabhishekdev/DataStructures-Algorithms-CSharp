using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;

namespace ProblemSolvingFromFirstPrinciples.Practice.PracticeSetThree
{
    public class WordSearchOneSetThree
    {
        public bool Exist(char[][] board, string word)
        {
            for(int i = 0; i < board.Length; i++)
            {
                for(int j = 0; j < board[i].Length; j++)
                {
                    if(DFSTravel(board, word, 0, i, j))
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        private bool DFSTravel(char[][] board, string word, int index, int i, int j)
        {
            if(index == word.Length)
            {
                return true;
            }

            if( i < 0 || i >= board.Length || j < 0 || j >= board[i].Length || board[i][j] != word[index])
            {
                return false;
            }

            char temp = board[i][j];
            board[i][j] = '#';

            bool found = DFSTravel(board, word, index+1, i+1,j) || DFSTravel(board, word, index+1, i-1,j) || DFSTravel(board, word, index+1, i,j+1) || DFSTravel(board, word, index+1, i,j-1);

            board[i][j] = temp;
            return found;
        }
    }
}