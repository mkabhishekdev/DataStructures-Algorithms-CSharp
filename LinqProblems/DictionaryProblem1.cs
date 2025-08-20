/*

1. Find First Non-Repeating Character in a String
Problem: Return the first non-repeating character from a string.

Test Case 1
Input: "swiss"
Expected Output: 'w'

Test Case 2
Input: "aabbcc"
Expected Output: null or -1

Time Complexity: O(n)
Space Complexity: O(n)
*/
public class DictionaryProblem1
{
    public string NonRepeating(string input)
    {
        Dictionary<char,int> store = new Dictionary<char,int>();
        
        for(int i = 0; i < input.Length; i++)
        {
            if(store.ContainsKey(input[i]))
            {
                store[input[i]]++;
            }
            else
            {
                store.Add(input[i],1);
            }
        }

        foreach(var item in store)
        {
            if(item.Value == 1)
            {
                return item.Key.ToString();
            }
        }

        return "";
    }
}


/*
DictionaryProblem1 dp1 = new DictionaryProblem1();
        Console.WriteLine("The first non repeating character is: " + dp1.NonRepeating("aabbcc"));
*/