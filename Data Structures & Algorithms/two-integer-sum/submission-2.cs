public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        //nums[i] + complement = target

        Dictionary<int, int> seen = new Dictionary<int, int>();
        for(int i=0;i<nums.Length;i++)        
        {
            int complement = target - nums[i];
            if(seen.ContainsKey(complement))
            {
                int index = seen[complement];
                return new int[] {index, i};
            }
            seen[nums[i]] = i;
        }
        return new int[0];
    }
}