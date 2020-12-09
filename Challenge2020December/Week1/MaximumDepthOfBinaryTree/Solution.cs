namespace MaximumDepthOfBinaryTree
{
    public class Solution
    {
        private int maxDepth = 0;
        
        public int MaxDepth(TreeNode root)
        {
            if (root == null)
                return 0;
            IncreaseDepth(0, root);

            return maxDepth;
        }

        private void IncreaseDepth(int currentDepth, TreeNode node)
        {
            int depth = currentDepth + 1;

            if (node.right != null)
            {
                IncreaseDepth(depth, node.right);
            }

            if (node.left != null)
            {
                IncreaseDepth(depth, node.left);
            }

            if (depth > maxDepth)
            {
                maxDepth = depth;
            }
        }
    }
}