using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCodeExperiments.Algorithms
{
    public class MedianOfArrays
    {
        /*
         * 4. Median of Two Sorted Arrays
Hard

4520

634

Favorite

Share
There are two sorted arrays nums1 and nums2 of size m and n respectively.

Find the median of the two sorted arrays. The overall run time complexity should be O(log (m+n)).

You may assume nums1 and nums2 cannot be both empty.

Example 1:

nums1 = [1, 3]
nums2 = [2]

The median is 2.0
Example 2:

nums1 = [1, 2]
nums2 = [3, 4]

The median is (2 + 3)/2 = 2.5
        */

        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            var result = 0.0;
            var combinedArray = new int[nums1.Length+ nums2.Length];
            if(nums1.Length>0)
            Array.Copy(nums1, combinedArray, nums1.Length);
            if (nums2.Length > 0)
                Array.Copy(nums2, 0, combinedArray, nums1.Length, nums2.Length);
            Array.Sort(combinedArray);

            var isEvenCollection = combinedArray.Length % 2==0;

            if (isEvenCollection)
            {
                var middleIndex = combinedArray.Length / 2;
                result = ((Double)combinedArray[middleIndex-1] + (Double)combinedArray[middleIndex]) / 2;
            }
             else
            {
                var middleIndex = ((int)(Math.Round((Double)combinedArray.Length / 2,MidpointRounding.AwayFromZero)) -1);
                middleIndex = (middleIndex < 0) ? 0 : middleIndex;

                result = combinedArray[middleIndex];
            }

            return result;
        }
    }
}
