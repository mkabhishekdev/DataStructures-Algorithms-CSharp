using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace ProblemSolvingFromFirstPrinciples.Trees.YourTHINKINGWork
{
    /* My approach
    1. this can be done using Trie datastructure
    2. implementing Trie, create TrieNode[26] and a boolean flag variable, also keep a dictionary
    3. for adding word, keep iterating and when reached the end of the flag set it to true
    4. for search, iterate and keep checking if you are finding the characters in a order and 
       the flag ends with a true value, if false than its not that word

    */

    /* any optimization later

    */

    /* time complexity: ForAdd= O(n)  , ForSearch= O(26 power of N)
    space complexity: ForAdd= O(n) , ForSearch= O(N) recursion stack during search
    */
    public class WordDictionaryImpl
    {
        public TrieNode root;

        public WordDictionaryImpl()
        {
            root = new TrieNode();
        }

        public void AddWord(string word)
        {
            TrieNode node = root;

            for(int i = 0; i < word.Length; i++)
            {
                if(!node.ContainsKey(word[i]))
                {
                    node.put(word[i],new TrieNode());    
                }
                node = node.get(word[i]);
            } 
            node.SetEnd();
        }

        public bool Search(string word)
        {
            return SearchHelper(word, 0, root);
        }

        private bool SearchHelper(string word, int index, TrieNode node)
        {
            if(node == null)
            {
                return false;
            }

            if(index == word.Length)
            {
                return node.IsEnd();
            }
            
            char ch = word[index];

            if(ch != '.')
            {
                if(!node.ContainsKey(ch))
                {
                    return false;
                }
                return SearchHelper(word, index + 1, node.get(ch));
            }
            else
            {
                for(int i = 0; i < 26; i++)
                {
                    TrieNode child = node.get((char)(i + 'a'));

                    if(child != null)
                    {
                        if(SearchHelper(word, index + 1, child))
                        {
                            return true;
                        }
                    }
                }
            }

            return false;

        }
    }
}