using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureInCSharp
{
    public class BTNode
    {
        public int data;
        public BTNode left,right;
        public BTNode(int data)
        {
            this.data = data;
            left = right = null;
        }

    }
    public class BinaryTree
    {
        public BTNode root;
        public BinaryTree(int data)
        {
            root = new BTNode(data);
        }
        public BinaryTree()
        {
            root = null;
        }
        public int getHeight(BTNode root)
        {
            if(root == null)
            {
                return 0;

            }
            else {
                int lHeight = getHeight(root.left);
                int rHeight = getHeight(root.right);
                if (lHeight > rHeight)
                    return lHeight + 1;
                else
                    return rHeight + 1;
            }
        }
        public void levelOrderTraverseWithouQueue()
        {
            int h = getHeight(root);
            for(int i = 1; i <= h ; i++)
            {
                displayGivenLevel(root, i);
            }
        }
        public void displayGivenLevel(BTNode root, int level)
        {
            if (root == null)
                return;
            if (level == 1)
                Console.WriteLine(root.data);
            else if(level > 1)
            {
                //Console.WriteLine(root.data);
                displayGivenLevel(root.left, level - 1);
                displayGivenLevel(root.right, level - 1);

            }
        }
        public void leveOrderTraveseWithQueue()
        {
            Queue<BTNode> queue = new Queue<BTNode>();
            queue.Enqueue(root);
            while(queue.Count > 0)
            {
                BTNode node = queue.Dequeue();
                Console.WriteLine(node.data);
                if (node.left != null) 
                queue.Enqueue(node.left);
                if (node.right != null) 
                queue.Enqueue(node.right);

            }
        }
        public void inOrderTraverseWithoutRecursion()
        {
            if (root == null)
                return;

            Stack<BTNode> stack = new Stack<BTNode>();
            BTNode node = root;

            while (node != null)
            {
                stack.Push(node);
                node = node.left;
            }

            while(stack.Count > 0)
            {
                node = stack.Pop();
                Console.WriteLine(node.data);
                if(node.right != null)
                {
                    node = node.right;

                    while(node!=null)
                    {
                        stack.Push(node);
                        node = node.left;
                    }
                }
            }
        }
    }
}
