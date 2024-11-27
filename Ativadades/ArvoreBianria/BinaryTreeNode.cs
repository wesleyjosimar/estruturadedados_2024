using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArvoreBianria
{
    public class BinaryTreeNode<T> : TreeNode<T>
    {
        public BinaryTreeNode()
        {
           base.Children = new List<TreeNode<T>>();
        }
    public BinaryTreeNode<T> Left
        {
            get { return (BinaryTreeNode<T>)Children![0]; }
            set { Children![0] = value;}
        }
     public BinaryTreeNode<T> Right
        {
            get { return (BinaryTreeNode<T>)Children![1]; }
            set { Children![1] = value;}
        }
    }
}