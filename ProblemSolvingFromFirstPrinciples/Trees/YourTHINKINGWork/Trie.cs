using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProblemSolvingFromFirstPrinciples.Trees.YourTHINKINGWork
{
    /* Approach
    1. Trie (i.e spelled 'try') is a DS where the idea is a link wise connection of nodes, like a specialized
       form of tree linking (prefix tree)
    2. first create a TrieNode datastructure (refer your TrieNode.cs file)
    3. you will have TrieNode[26](its like the 'char' based indexing approach)
    4. than will have a boolean flag to check if the next referenced trie is pointing to what and based on that
       will update the flag boolean value
    */

    /* any optimization later

    */

    /* time complexity:
    space complexity:
    */
    public class Trie
    {
        private static TrieNode root;

        public Trie()
        {
            root = new TrieNode();    
        }

        public void Insert(string word)
        {
            TrieNode node = root;

            for(int i = 0; i < word.Length; i++)
            {
                if(!node.ContainsKey(word[i]))
                {
                    node.put(word[i],new TrieNode());
                }

                // this line moves to the reference trie
                node = node.get(word[i]);
            }

            node.SetEnd();
        }

        public bool Search(string word)
        {
            TrieNode node = root;

            for(int i = 0; i < word.Length; i++)
            {
                if(!node.ContainsKey(word[i]))
                {
                    return false;
                }
                node = node.get(word[i]);
            }
            if(node.IsEnd())
            {
                return true;
            }
            return false;
        }

        public bool StartsWith(string prefix)
        {
            TrieNode node = root;

            for(int i = 0; i < prefix.Length; i++)
            {
                if(!node.ContainsKey(prefix[i]))
                {
                    return false;
                }
                node = node.get(prefix[i]);
            }

            return true;
        }
    }
}