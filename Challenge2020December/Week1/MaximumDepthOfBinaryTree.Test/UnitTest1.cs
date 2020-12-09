using System;
using Xunit;

namespace MaximumDepthOfBinaryTree.Test
{
    public class UnitTest1
    {
        [Fact]
        public void TestDepthOfThree()
        {
            var l3lr = new TreeNode(7);
            var l3ll = new TreeNode(15);
            
            var l2xr = new TreeNode(20, l3ll, l3lr);
            var l2xl = new TreeNode(9);
            
            var root = new TreeNode(3, l2xl, l2xr);
            
            var solution = new Solution();
            var depth = solution.MaxDepth(root);
            
            Assert.Equal(3, depth);
        }

        [Fact]
        public void TestDepthOfTwo()
        {
            var l2xl = new TreeNode(2);
            
            var root = new TreeNode(1, null, l2xl);
            
            var solution = new Solution();
            var depth = solution.MaxDepth(root);
            
            Assert.Equal(2, depth);
        }
        
        [Fact]
        public void TestDepthOfNullRoot()
        {
            var solution = new Solution();
            var depth = solution.MaxDepth(null);
            
            Assert.Equal(0, depth);
        }
        
        [Fact]
        public void TestDepthOfRootOnly()
        {
            var solution = new Solution();
            var depth = solution.MaxDepth(new TreeNode(0));
            
            Assert.Equal(1, depth);
        }
        
    }
}