/*

3. Find First Non-Repeating Character
Problem: Given a string, find the first character that does not repeat.

Testcase1: 
Input: "swiss"
Expected Output: 'w'
Reason: 's' repeats, 'w' is the first character that doesn’t repeat.

Testcase2:
Input: "zxyxz"
Expected Output: 'y'
Reason: 'y' is the first character that doesn’t repeat.

Time Complexity: O(n)
Space Complexity: O(n)
*/
public class StringProblem3
{
    public char NonRepeatingCharacter(string input)
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
                store.Add(input[i], 1);
            }
        }

        foreach(var item in store)
        {
            if(item.Value == 1)
            {
                return item.Key;
            }
        }

        return default(char);
    }
}


/*

        StringProblem3 sp3 = new StringProblem3();

        Console.WriteLine("The first non repeating character is: "+sp3.NonRepeatingCharacter("zxyxz"));
*/