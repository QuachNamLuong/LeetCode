package main

func n2(nums []int, target int) []int {
	lenNums := len(nums)
	for i, num := range nums {
		for j := i + 1; j < lenNums; j++ {
			if num + nums[j] == target {
				return []int{i, j}
			}
		}
	}
	return []int{}
}

func n(nums []int, target int) []int {
	numsMap := make(map[int]int)

	for i, num := range nums {
		complement := target - num
		value, ok := numsMap[complement]
		if ok {
			return []int{value, i}
		}

		numsMap[num] = i
	}

	return []int{}
}

func twoSum(nums []int, target int) []int {
    return n2(nums, target)
}