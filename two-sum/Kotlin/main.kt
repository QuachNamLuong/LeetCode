import kotlin.intArrayOf
import java.util.Dictionary

class Solution {
    private fun n2(nums: IntArray, target: Int): IntArray { 
        for ((index, value) in nums.withIndex()) {
            for(i in index + 1 until nums.size) {
                if (value + nums[i] == target) return intArrayOf(index, i)
            }
        }
        return IntArray(size = 0)
    }

    private fun n(nums: IntArray, target: Int): IntArray {
        val map = HashMap<Int, Int>(nums.size)
        nums.forEachIndexed { index, value ->
            val complement = target - value
            map[complement]?.let { return intArrayOf(it, index) }
            map[value] = index
        }
        return intArrayOf()
    }


    fun twoSum(nums: IntArray, target: Int): IntArray {
        return  n(nums, target)
    }
}