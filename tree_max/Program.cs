using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tree_max
{
    class Program
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

            
            public static int findMax(Node node)
            {
                if (node == null)
                {
                    return int.MinValue;
                }

                int res = node.data;
                int lres = findMax(node.left);
                int rres = findMax(node.right);

                if (lres > res)
                {
                    res = lres;
                }
                if (rres > res)
                {
                    res = rres;
                }
                return res;
            }


            public static void Main(string[] args)
            {
                BinaryTree tree = new BinaryTree();
                tree.root = new Node(3);
                tree.root.left = new Node(14);
                tree.root.right = new Node(25);
                tree.root.left.right = new Node(36);
                tree.root.left.right.left = new Node(12);
                tree.root.left.right.right = new Node(11);
                tree.root.right.right = new Node(91);
                tree.root.right.right.left = new Node(4);

                Console.WriteLine("Maximum element is " + BinaryTree.findMax(tree.root));
                Console.ReadLine();
            }

        }
    }
}