public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var frequencies = new Dictionary<int, int>();

        foreach (var num in nums)
        {
            if (!frequencies.ContainsKey(num)) frequencies[num] = 0;

            frequencies[num]++;
        }

        return frequencies.OrderByDescending(pair => pair.Value)
            .Take(k)
            .Select(pair => pair.Key)
            .ToArray();
    }
}