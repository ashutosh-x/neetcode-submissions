public class Solution {
    public int SingleNumber(int[] nums) {
        Dictionary<int, int> collection = new Dictionary<int, int>();
        foreach (var item in nums) {
            if (collection.ContainsKey(item)) {
                collection[item]++;
            } else {
                collection[item] = 1;
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