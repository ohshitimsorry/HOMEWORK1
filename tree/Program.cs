using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tree
{
    public class Node
    {
        public int data;
        public Node left, right;

        public Node(int data)
        {
            this.data = data;
            left = right = null;
        }
    }

    public class BinaryTree
    {
        public Node root;

        // Returns the max value in a binary tree  
        public static int findMin(Node node)
        {
            if (node == null)
                return int.MaxValue;

            int res = node.data;
            int lres = findMin(node.left);
            int rres = findMin(node.right);

            if (lres < res)
                res = lres;
            if (rres < res)
                res = rres;
            return res;
        }

        /* Driver program to test above functions */
        public static void Main(string[] args)
        {
            BinaryTree tree = new BinaryTree();
            tree.root = new Node(2);
            tree.root.left = new Node(7);
            tree.root.right = new Node(5);
            tree.root.left.right = new Node(6);
            tree.root.left.right.left = new Node(1);
            tree.root.left.right.right = new Node(11);
            tree.root.right.right = new Node(9);
            tree.root.right.right.left = new Node(4);

            Console.WriteLine("Maximum element is " + BinaryTree.findMin(tree.root));
            Console.ReadLine();
        }  

    }
}