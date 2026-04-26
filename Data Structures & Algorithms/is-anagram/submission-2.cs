public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length == t.Length)
        {
            Dictionary<char, int> collection = new Dictionary<char, int>();
            foreach(var item in s.ToCharArray())
            {
                if(collection.ContainsKey(item))
                {
                    collection[item]++;
                }
                else
                {
                    collection[item] = 1;
                }
            }
            foreach(var item in t.ToCharArray())
            {
                if(collection.ContainsKey(item) && collection[item] > 0)
                {
                    collection[item]--;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
        else
        {
            return false;
        }
    }
}
