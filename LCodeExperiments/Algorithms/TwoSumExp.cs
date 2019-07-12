using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCodeExperiments.Algorithms
{
    /*
     * Given an array of integers, return indices of the two numbers such that they add up to a specific target.

        You may assume that each input would have exactly one solution, and you may not use the same element twice.

        Example:

        Given nums = [2, 7, 11, 15], target = 9,

        Because nums[0] + nums[1] = 2 + 7 = 9,
        return [0, 1].
     * */
    public class TwoSumExp
    {
        public int[] TwoSum(int[] nums, int target)
        {
            var abc = new int[2];
            foreach (var n in nums)
            {
                var currentNo = n;
                var remaingNo = target - n;
               

                var currentNoIndex = Array.IndexOf(nums, currentNo);
                var remaingNoIndex = Array.IndexOf(nums, remaingNo,currentNoIndex+1);

                if (remaingNoIndex == -1 || currentNoIndex==remaingNoIndex)
                    continue;

                abc[0] = currentNoIndex;
                abc[1] = remaingNoIndex;
                return abc;
            }

            return abc;
        }
    }


}
