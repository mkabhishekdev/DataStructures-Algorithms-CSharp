using System;
using System.Collections;
using System.Text.RegularExpressions;

public class ProblemOneValidPalindrome
{
    public bool CheckPalindrome(string input)
    {
        if (input == null)
        {
            return false;
        }

        if (input.Equals(" "))
        {
            return true;
        }

        string filteredInput = Regex.Replace(input, "[^a-zA-Z0-9]", String.Empty);

        List<char> storeInput = new List<char>();

        for (int i = filteredInput.Length - 1; i >= 0; i--)
        {
            storeInput.Add(filteredInput[i]);
        }

        string reversedInput = new string(storeInput.ToArray());

        if (reversedInput.ToLower().Equals(filteredInput.ToLower()))
        {
            return true;
        }

        return false;

    }
}

// SCORE = 8.5/10