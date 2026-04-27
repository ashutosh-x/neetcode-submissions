public class Solution {
    public bool IsAnagram(string s, string t) {
        char[] sChar = s.ToCharArray();
        char[] tChar = t.ToCharArray();

        if(sChar.Length == tChar.Length)
        {
            Dictionary<char, int> freq = new Dictionary<char, int>();
            foreach(var item in sChar)
            {
                if(freq.ContainsKey(item))
                {
                    freq[item]++;
                }
                else
                {
                    freq[item] = 1;
                }
            }

            foreach(var item in tChar)
            {
                if(freq.ContainsKey(item))
                {
                    freq[item]--;
                }
                else
                {
                    return false;
                }
            }

            foreach(var count in freq.Values)
            {
                if(count != 0) return false;
            }
            return true;
        }

        return false;
    }
}