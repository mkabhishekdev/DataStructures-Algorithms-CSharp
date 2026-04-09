using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProblemSolvingFromFirstPrinciples.Graph.YourTHINKINGWork
{
    /* My Approach
    1. iterate through the grid of characters
    2. find the first char in the board and call the Search method
    3. search method will check all the adjacent elements in all the directions i+1,i-1,j+1,j-1
    4. 
    */

    /* any optimization later

    */

    /* time complexity:
    space complexity:
    */
    public class WordSearchMedium
    {
        bool[][] visited;
        public bool Exist(char[][] board, string word)
        {
            visited = new bool[board.Length][];

            for(int i = 0; i < board.Length; i++)
            {
                visited[i] = new bool[board[0].Length];    
            }

            for(int i = 0; i < board.Length; i++)
            {
                for(int j = 0; j < board[i].Length; j++)
                {
                    if(word[0] == board[i][j] && SearchWord(i,j,0,word,board))
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public bool SearchWord(int i, int j, int index, string word, char[][] board)
        {
            if(index == word.Length)
            {
                return true;
            }

            if( i < 0 || i >= board.Length || j < 0 || j >= board[i].Length || word[index] != board[i][j] || visited[i][j])
            {
                return false;
            }

            visited[i][j] = true;

            if(SearchWord(i+1,j,index+1,word,board) || SearchWord(i-1,j,index+1,word,board)
               || SearchWord(i,j+1,index+1,word,board) || SearchWord(i,j-1,index+1,word,board))
            {
                return true;
            }

            visited[i][j] = false;

            return false;
        }
    }
} 