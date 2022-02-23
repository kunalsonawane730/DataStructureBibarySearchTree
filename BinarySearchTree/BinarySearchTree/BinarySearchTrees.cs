using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class BinarySearchTrees
    {
        public Node rootNode;
        public void BinarySearchTree()
        {
            rootNode = null;
        }
        public void InsertingNode(int element)
        {
            if (rootNode == null)
            {
                rootNode = new Node(element);
                return;
            }
            InsertingElement(rootNode, new Node(element));
        }

        public void InsertingElement(Node root, Node newNode)
        {
            if (root == null)
            {
                root = newNode;
            }

            if (newNode.Element < root.Element)
            {
                if (root.Leftside == null)
                {
                    root.Leftside = newNode;
                }
                else
                {
                    InsertingElement(root.Leftside, newNode);
                }
            }
            else
            {
                if (root.Rightside == null)
                {
                    root.Rightside = newNode;
                }
                else
                {
                    InsertingElement(root.Rightside, newNode);
                }
            }
        }

        public void Display(Node root)
        {
            if (root == null)
            {
                return;
            }

            Display(root.Leftside);
            Console.Write(root.Element + ", ");
            Display(root.Rightside);
        }

        public void Display()
        {
            Console.WriteLine("Now Elements are:");
            Display(rootNode);
        }
    }
}
