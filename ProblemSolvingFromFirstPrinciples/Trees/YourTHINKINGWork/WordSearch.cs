using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Threading.Tasks;

namespace InterviewLabCodeRepo.Interview
{
    /* My Approach
    1. each character in the word should be adjacent vertically or adjacent horizontally 
    2. need to traverse through the board[][] matrix
    3. within the loop iteration, need to check if the next char in the word is adjacent horizontally or
    adjacent vertically
    4. if any of the char is not found -> return []
    5. if the entire word you traversa and find all the char adjacent horizontally and vertically -> add them into the
       result list
    */

    /* any optimization later

    */

    /* time complexity:
    space complexity:
    */
  
    public class WordSearch
    {
        public IList<string> FindWords(char[][] board, string[] words)
        {
            for(int i = 0; i < board.Length; i++)
            {
                for(int j = 0; j < board[i].Length; j++)
                {
                    foreach(var word in words)
                    {
                        if(board[i][j] == word[0])
                        {
                            /* need this logic here: need to check if the next char in the word is adjacent horizontally or
    adjacent vertically */
    
                        }
                    }
                }
            }
        }
    }
}