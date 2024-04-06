public class Solution 
{
    public int[] TwoSum(int[] nums, int targetSum) 
    {
        var numToIndex = new Dictionary<int, int>();

        for(var i = 0; i < nums.Length; i++)
        {
            var complement = targetSum - nums[i];

            if (numToIndex.ContainsKey(complement)) return new int[]{numToIndex[complement], i};

            numToIndex.TryAdd(nums[i], i);
        }

        return Array.Empty<int>();
    }
}