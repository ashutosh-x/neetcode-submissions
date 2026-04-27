public class Solution {
    public bool hasDuplicate(int[] nums) {
        
        Dictionary<int, int> freq = new Dictionary<int, int>();
        
        foreach(var item in nums)
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

        foreach(var item in freq)
        {
            if(item.Value > 1)
            {
                return true;
            }
        }
        return false;
    }
}