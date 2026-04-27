public class Solution {
    public int Search(int[] nums, int target) {
        Dictionary<int, int> collection = new Dictionary<int, int>();
        if (nums.Length >= 1 && nums.Length <= 10000) {
            for (int i = 0; i < nums.Length; i++) {
                if (-10000 < nums[i] && target < 10000) {
                    if (nums[i] == target) {
                        return i;
                    }
                }
            }
        }
        return -1;
    }
}