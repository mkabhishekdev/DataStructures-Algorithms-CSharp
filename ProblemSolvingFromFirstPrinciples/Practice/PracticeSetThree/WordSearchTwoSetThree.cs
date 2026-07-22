using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProblemSolvingFromFirstPrinciples.Practice.PracticeSetThree
{
    public class WordSearchTwoSetThree
    {
        public IList<string> FindWords(char[][] board, string[] words)
        {
            IList<string> result = new List<string>();

            foreach(string word in words)
            {
                for(int i = 0; i < board.Length; i++)
                {
                    for(int j = 0; j < board[i].Length; j++)
                    {
                        if(DFSPath(board, word, 0, i, j))
                        {
                            int count = 0;

                            for(int x = 0; x < result.Count; x++)
                            {
                                if(result[x] == word)
                                {
                                    count++;
                                }
                            }
                            if(count == 0)
                            {
                                result.Add(word);
                            }
                        }
                    }
                }
            }

            return result;
        }

        private bool DFSPath(char[][] board, string word, int index, int i, int j)
        {
            if(index == word.Length)
            {
                return true;
            }

            if((i<0) || (i>=board.Length) || (j<0) || (j>=board[i].Length) || (board[i][j] != word[index]))
            {
                return false;
            }

            char temp = board[i][j];
            board[i][j] = '#';

            bool found = DFSPath(board, word, index+1, i+1,j) || DFSPath(board, word, index+1, i-1,j)
                            || DFSPath(board, word, index+1, i,j+1) || DFSPath(board, word, index+1, i,j-1);
            
            board[i][j] = temp;

            return found;
        }
    }
}