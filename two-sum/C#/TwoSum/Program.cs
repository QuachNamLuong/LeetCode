public class Solution
{
    //O = N^2
    private int[] N2(int[] nums, int target)
    {
        for (var i = 0; i < nums.Length; ++i)
        {
            for (var j = i + 1; j < nums.Length; ++j)
            {
                if (nums[i] + nums[j] == target) return [i, j];
            }
        }
        return [];
    }

    //O = N
    private int[] N(int[] nums, int target)
    {
        //Key = nums[i], value = i
        var dict = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; ++i)
        {
            var complement = target - nums[i];
            if (dict.TryGetValue(complement, out int value)) return [value, i];

            dict.TryAdd(nums[i], i);
        }

        return [];
    }

    public int[] TwoSum(int[] nums, int target)
    {
        return N(nums, target);
    }
}