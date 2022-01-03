using Problems.Helpers;

namespace Problems
{
    public class PathSum112
    {
        public bool HasPathSum(TreeNode root, int targetSum)
        {

            if (root == null) return false;

            if (isLeaf(root)) return root.val == targetSum;

            return HasPathSum(root.left, targetSum - root.val)
                || HasPathSum(root.right, targetSum - root.val);
        }

        private bool isLeaf(TreeNode root)
        {
            return root.left == null && root.right == null;
        }
    }
}
