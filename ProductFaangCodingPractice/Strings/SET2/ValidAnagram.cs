//TIME: 45 minutes , Easy:10pts, Med:20pts, Hard:30pts

public class Set1Problem1ValidAnagram
{
    public bool IsAnagram(string s, string t)
    {
        Dictionary<char, int> sStore = new Dictionary<char, int>();
        Dictionary<char, int> tStore = new Dictionary<char, int>();

        for (int i = 0; i < s.Length; i++)
        {
            if (sStore.ContainsKey(s[i]))
            {
                sStore[s[i]]++;
            }
            else
            {
                sStore.Add(s[i], 1);
            }
        }

        for (int i = 0; i < t.Length; i++)
        {
            if (tStore.ContainsKey(t[i]))
            {
                tStore[t[i]]++;
            }
            else
            {
                tStore.Add(t[i], 1);
            }
        }

        bool result = sStore.OrderBy(kv => kv.Key).SequenceEqual(tStore.OrderBy(kv => kv.Key));

        return result;
    }

}

// SCORE: 9/10