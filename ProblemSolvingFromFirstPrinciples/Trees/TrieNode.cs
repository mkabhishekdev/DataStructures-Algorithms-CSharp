using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProblemSolvingFromFirstPrinciples.Trees
{
    public class TrieNode
    {
        TrieNode[] links = new TrieNode[26];
        bool flag = false;

        public TrieNode()
        {
            
        }

        public bool ContainsKey(char ch)
        {
            return (links[ch - 'a'] != NULL);
        }

        public void put(char ch, TrieNode node)
        {
            links[ch - 'a'] = node;
        }
        
        public TrieNode get(char ch)
        {
            return links[ch - 'a'];
        }

        public void SetEnd()
        {
            flag = true;
        }

        public bool IsEnd()
        {
            return flag;
        }

    }
}