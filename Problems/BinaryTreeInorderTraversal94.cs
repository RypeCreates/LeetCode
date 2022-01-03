using System.Collections.Generic;
using Problems.Helpers;

namespace Problems
{
    public class BinaryTreeInorderTraversal94
    {
        /*
            Algorithm Inorder(tree)
            1. Traverse the left subtree, i.e., call Inorder(left-subtree)
            2. Visit the root.
            3. Traverse the right subtree, i.e., call Inorder(right-subtree)         
         */

        public IList<int> InorderTraversal(TreeNode root)
        {
            var vals = new List<int>();

            if (root is null) return vals;

            vals.AddRange(InorderTraversal(root.left));
            vals.Add(root.val);
            vals.AddRange(InorderTraversal(root.right));

            return vals;
        }
    }
}
