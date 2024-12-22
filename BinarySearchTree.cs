using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arbol_de_busqueda
{
    public class BinarySearchTree
    {
        private TreeNode? Root;

        public void Insert(int value)
        {
            Root = InsertRec(Root, value);
        }

        private TreeNode InsertRec(TreeNode? node, int value)
        {
            if (node == null)
            {
                return new TreeNode(value);
            }
            if (value < node.Value)
            {
                node.Left = InsertRec(node.Left, value);
            }
            else
            {
                node.Right = InsertRec(node.Right, value);
            }
            return node;
        }

        public bool Contains(int value)
        {
            return ContainsRec(Root, value);
        }

        private bool ContainsRec(TreeNode? node, int value)
        {
            if (node == null)
            {
                return false;
            }
            if (value == node.Value)
            {
                return true;
            }
            return value < node.Value ? ContainsRec(node.Left, value) : ContainsRec(node.Right, value);
        }
    }

}
