public class Solution {
    public bool ContainsDuplicate(int[] nums) 
    {
        var unique = new HashSet<int>(nums.Length);

        foreach(int num in nums) 
        {
            if (unique.Contains(num)) 
            {
                return true;
            }
            unique.Add(num);
        }

        return false;
    }
}