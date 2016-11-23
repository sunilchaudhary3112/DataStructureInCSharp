using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureInCSharp
{
    public class BSTNode
    {
        public int data;
        public BSTNode left, right;
        public BSTNode(int data)
        {
            this.data = data;
            left = right = null;
        }

    }
    public class BST
    {
        public BSTNode root;
        public BST()
        {
            root = null;
        }
        public void insert(int data)
        {
           root = insertRec(root, data);

        }
        public BSTNode search(BSTNode root, int data)
        {
            if (root == null)
                return null;
            if (root.data == data)
                return root;
            if (root.data > data)
                return search(root.left, data);
            else
                return search(root.right, data);
        }
        public BSTNode insertRec(BSTNode root, int data)
        {
            if(root == null)
            {
                root = new BSTNode(data);
                return root;
            }

            if(root.data > data)
            {
                root.left = insertRec(root.left, data);
            }
            else if (root.data < data)
            {
                root.right = insertRec(root.right, data);
            }
            return root;
        }
        public void inorder(BSTNode root)
        {
            if (root == null)
                return;
            
                inorder(root.left);
            Console.WriteLine(root.data);
            
                inorder(root.right);
        }
        public void delete(int data)
        {
            root = deleteRec(root, data);
        }
        public BSTNode deleteRec(BSTNode root, int data)
        {
            if(root == null)
            {
                return root;
            }
            if (root.data > data)
                root.left = deleteRec(root.left, data);
            else if (root.data < data)
                root.right = deleteRec(root.right, data);

            else
            {
                //this is the node to delete
                if (root.left == null)
                    return root.right;
                if (root.right == null)
                    return root.left;

                root.data = minValue(root.right);

                root.right = deleteRec(root.right, root.data);
            }
            return root;
        }
        public int minValue(BSTNode root)
        {
            int minVal = root.data;
            while(root.left != null)
            {
                minVal = root.left.data;
                root = root.left;
            }
            return minVal;
        }
    }
}
