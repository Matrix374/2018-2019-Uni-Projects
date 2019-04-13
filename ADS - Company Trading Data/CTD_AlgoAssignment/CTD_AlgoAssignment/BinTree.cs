using System;
using System.ComponentModel;

namespace CTD_AlgoAssignment
{
    class BinTree<T> where T : Component
    {
        protected Node<T> root;
        public BinTree()  //creates an empty tree
        {
            Root = null;
        }
        public BinTree(Node<T> node)  //creates a tree with node as the root
        {
            Root = node;
        }

        public Node<T> Root { get => root; set => root = value; }

        public void PreOrder(ref string buffer)
        {
            preOrder(root, ref buffer);
        }
        private void preOrder(Node<T> temp, ref string buffer)
        {
            if (temp != null)
            {
                buffer += temp.Data.ToString() + ",";
                preOrder(temp.Left, ref buffer);

                preOrder(temp.Right, ref buffer);
            }
        }

        public void InOrder(ref string buffer)
        {
            inOrder(root, ref buffer);
        }

        private void inOrder(Node<T> tree, ref string buffer)
        {
            if (tree != null)
            {
                inOrder(tree.Left, ref buffer);
                buffer += tree.Data.ToString() + ",";
                inOrder(tree.Right, ref buffer);
            }
        }

        public void PostOrder(ref string buffer)
        {
            postOrder(root, ref buffer);
        }

        private void postOrder(Node<T> tree, ref string buffer)
        {
            if (tree != null)
            {
                postOrder(tree.Left, ref buffer);
                postOrder(tree.Right, ref buffer);
                buffer += tree.Data.ToString() + ",";
            }
        }
        public void Copy(BinTree<T> tree2)
        {
            copy(ref root, tree2.Root);
        }

        private void copy(ref Node<T> tree, Node<T> tree2)
        {
            if (tree2 != null)
            {
                tree = tree2;
                copy(ref tree.Left, tree2.Left);
                copy(ref tree.Right, tree2.Right);
            }
        }

        public void Count(ref int counter)
        {
            count(root, ref counter);
        }

        private void count(Node<T> tree, ref int counter)
        {
            if (tree != null)
            {
                counter++;

                count(tree.Left, ref counter);
                count(tree.Right, ref counter);
            }
        }

    }
}