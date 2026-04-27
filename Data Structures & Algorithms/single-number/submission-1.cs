public class Solution {
    public int SingleNumber(int[] nums) {
        Dictionary<int, int> collection = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++) {
            if (collection.ContainsKey(nums[i])) {
                collection[nums[i]]++;
            } else {
                collection[nums[i]] = 1;
            }
        }

        foreach (var item in collection) {
            if (item.Value == 1) {
                return item.Key;
            }
        }
        return -1;
    }
}