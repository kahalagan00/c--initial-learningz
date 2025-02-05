using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Solution
    {
        public int[] TwoSum(int[] nums, int target) {
            for (int i = 0; i < nums.Length - 1; ++i) {
                for (int j = i + 1; j < nums.Length; ++j) {
                    if (nums[i] + nums[j] == target) {
                        return new int[] {i, j};
                    }
                }
            }

            throw new ArgumentException("No solution");
        }
    }
}