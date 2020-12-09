using System;

namespace MaximumDepthOfBinaryTree
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var solution = new Solution();

            var root = BuildTree();

            var depth = solution.MaxDepth(root);
            
            Console.WriteLine($"Depth: {depth}");
        }

        private static TreeNode BuildTree()
        {
            var leaf2Right = new TreeNode(7);
            var leaf2Left = new TreeNode(15);
            
            var leaf1Right = new TreeNode(20, leaf2Left, leaf2Right);
            var leaf1Left = new TreeNode(9);
            
            var root = new TreeNode(3, leaf1Left, leaf1Right);

            return root;
        }
    }
}