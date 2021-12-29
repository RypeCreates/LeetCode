using System;
using Problems.Helpers;

namespace Problems
{
    public class SortedArraytoBinarySearch
    {
        public TreeNode SortedArrayToBST(int[] nums)
        {

            if (nums.Length == 0) return null;

            if (nums.Length == 1) return new TreeNode(nums[0]);

            // create root from midpoint
            var midIndex = (int)(nums.Length / 2);
            var root = new TreeNode(nums[midIndex]);

            // create two subArrays for each side of the root

            // left 

            var subArrayLeft = new int[midIndex];

            Array.Copy(nums, 0, subArrayLeft, 0, midIndex);
            root.left = SortedArrayToBST(subArrayLeft);

            // right 

            var subArrayRight = new int[nums.Length - midIndex];
            Array.Copy(nums, midIndex, subArrayRight, 0, nums.Length - 1);
            root.right = SortedArrayToBST(subArrayRight);

            return root;
        }
    }
}
