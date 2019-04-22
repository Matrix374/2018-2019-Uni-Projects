using System;
using System.Collections;

namespace CTD_AlgoAssignment
{
    class BSTree<T> : BinTree<T> where T : IComparable
    {
        public BSTree()
        {
            root = null;
        }

        public void InsertItem(T item)
        {
            insertItem(item, ref root);
        }

        private void insertItem(T item, ref Node<T> tree)
        {
            if (tree == null)
            {
                tree = new Node<T>(item);
            }
            else if (item.CompareTo(tree.Data) < 0)
            {
                insertItem(item, ref tree.Left);
            }
            else if (item.CompareTo(tree.Data) > 0)
            {
                insertItem(item, ref tree.Right);
            }
        }

        public int Height()
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

        public int Count()
        {
            int counter = 0;

            Count(ref counter, root);

            return counter;
        }

        private int Count(ref int counter, Node<T> tree)
        {
            if (tree != null)
            {
                counter++;
                Count(ref counter, tree.Left);
                Count(ref counter, tree.Right);
            }
            return counter;
        }

        public Boolean Contains(T item)
        {
            Boolean result = false;

            result = Contains(item, ref result, root);

            return result;
        }

        private Boolean Contains(T item, ref Boolean result, Node<T> tree)
        {
            if (tree != null)
            {


                if (item.CompareTo(tree.Data) < 0)
                    Contains(item, ref result, tree.Left);
                else if (item.CompareTo(tree.Data) > 0)
                    Contains(item, ref result, tree.Right);

                if (tree.Data.CompareTo(item) == 0)
                {
                    result = true;
                }
            }
            return result;
        }

        public Node<T> GetNode(T item)
        {
            Node<T> result = null;

            result = getNode(item, ref result, root);

            return result;
        }

        private Node<T> getNode(T item, ref Node<T> result, Node<T> tree)
        {
            if (tree != null)
            {

                if (item.CompareTo(tree.Data) < 0)
                    getNode(item, ref result, tree.Left);
                else if (item.CompareTo(tree.Data) > 0)
                    getNode(item, ref result, tree.Right);

                if (tree.Data.CompareTo(item) == 0)
                {
                    result = tree;
                }
            }
            return result;
        }

        public ArrayList GetAll()
        {
            ArrayList result = new ArrayList();

            getAll(ref result, root);

            return result;
        }

        private void getAll(ref ArrayList result, Node<T> tree)
        {
            if(tree != null)
            {
                result.Add(tree.Data);
                getAll(ref result, tree.Left);
                getAll(ref result, tree.Right);
            }
        }

        public void RemoveItem(T item)
        {
            RemoveItem(item, ref root);
        }
        private void RemoveItem(T item, ref Node<T> tree)
        {
            if (tree != null)
            {
                if (item.CompareTo(tree.Data) < 0)
                    RemoveItem(item, ref tree.Left);
                else if (item.CompareTo(tree.Data) > 0)
                    RemoveItem(item, ref tree.Right);

                if (tree.Data.CompareTo(item) == 0)
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
                        RemoveItem(newRoot, ref tree.Right);
                    }

                }
            }
        }

        public void EditNode(Node<T> target)
        {
            editNode(target, ref root);
        }

        private void editNode(Node<T> target,ref Node<T> tree)
        {
            if (tree != null)
            {
                if (target.Data.CompareTo(tree.Data) < 0)
                    editNode(target, ref tree.Left);
                else if (target.Data.CompareTo(tree.Data) > 0)
                    editNode(target, ref tree.Right);

                if(target.Data.CompareTo(tree.Data) == 0)
                {
                    tree.Data = target.Data;
                }
            }
        }

        public T leastItem(Node<T> tree)
        {
            if (tree.Left == null)
                return tree.Data;
            else
            {
                return leastItem(tree.Left);
            }
        }

        public void CopyTo(ref BSTree<T> tree)
        {
            //copies the nodes of this BSTree object into tree maintaining the same structure and order.
        }
        public bool Equals(BSTree<T> tree)
        {
            //returns true if this BSTree object contains the all same data as
            //tree with the same structure and ordering of data.
            return false;
        }
        public bool SubTree(BSTree<T> tree)
        {
            //returns true if this BSTree object contains the subtree tree. 
            //A subtree of a tree T is a tree consisting of a node in T and all
            // of its descendants in T
            return false;
        }
    }
}