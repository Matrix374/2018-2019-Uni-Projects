using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTD_AlgoAssignment
{
    class AVLTree<T> : BSTree<T> where T : IComparable
    {
        public new void InsertItem(T item)
        {
            insertItem(item, ref root);
        }

        private void insertItem(T item, ref Node<T> tree)
        {
            if (tree == null)
                tree = new Node<T>(item);
            else if (item.CompareTo(tree.Data) < 0)
                insertItem(item, ref tree.Left);
            else if (item.CompareTo(tree.Data) > 0)
                insertItem(item, ref tree.Right);

            tree.BalanceFactor = height(tree.Left) - height(tree.Right);

            if (tree.BalanceFactor <= -2)
                rotateLeft(ref tree);
            if (tree.BalanceFactor >= 2)
                rotateRight(ref tree);

        }

        private void rotateLeft(ref Node<T> tree)
        {
            if (tree.Right.BalanceFactor > 0)  //double rotate
                rotateRight(ref tree.Right);

            Node<T> oldRoot = tree;
            Node<T> newRoot = tree.Right;

            oldRoot.Right = newRoot.Left;
            newRoot.Left = oldRoot;

            tree = newRoot;
        }

        private void rotateRight(ref Node<T> tree)
        {
            if (tree.Left.BalanceFactor < 0)  //double rotate
                rotateLeft(ref tree.Left);

            Node<T> oldRoot = tree;
            Node<T> newRoot = tree.Left;

            oldRoot.Left = newRoot.Right;
            newRoot.Right = oldRoot;

            tree = newRoot;

        }

        public new void RemoveItem(T item)
        {
            removeItem(item, ref root);
        }

        private void removeItem(T item, ref Node<T> tree)
        {
            if(tree != null)
            {
                if (item.CompareTo(tree.Data) < 0)
                    removeItem(item, ref tree.Left);
                else if (item.CompareTo(tree.Data) > 0)
                    removeItem(item, ref tree.Right);
                else if (tree.Data.CompareTo(item) == 0)
                {
                    if (tree.Left == null && tree.Right == null)
                        tree = null;
                    else if (tree.Left == null && tree.Right != null)
                        tree = tree.Right;
                    else if (tree.Right == null && tree.Left != null)
                        tree = tree.Left;
                    else if (tree.Right != null && tree.Left != null)
                    {
                        T newRoot = leastItem(tree.Right);
                        tree.Data = newRoot;
                        removeItem(newRoot, ref tree.Right);
                    }
                }

                if(tree!=null)
                {
                    if (tree.Left != null && tree.Right != null)
                    {
                        tree.BalanceFactor = height(tree.Left) - height(tree.Right);
                        int balance = tree.BalanceFactor;

                        if (balance >= 2)
                            rotateRight(ref tree);

                        if (balance <= -2)
                            rotateLeft(ref tree);
                    }
                }
            }
        }

        public new int Height()
        {
            int max = height(root);

            return max;
        }

        protected int height(Node<T> tree)
        {
            if (tree == null)
            {
                return 0;
            }

            return 1 + Math.Max(height(tree.Right), height(tree.Left));
        }
    }
}
