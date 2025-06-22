class Solution {
  List<int> n2(List<int> nums, int target) {
    int j = 0;
    for (int i = 0; i < nums.length; ++i) {
      for (j = i + 1; j < nums.length; ++j) {
        if (nums[i] + nums[j] == target) return [i, j];
      }
    }
    return const [];
  }

  List<int> n(List<int> nums, int target) {
    final m = <int, int>{};

    for (int i = 0; i < nums.length; i++) {
      final complement = target - nums[i];

      if (m.containsKey(complement)) {
        return [m[complement]!, i];
      }

      m[nums[i]] = i;
    }

    return const [];
  }

  List<int> twoSum(List<int> nums, int target) {
    return n2(nums, target);
  }
}
