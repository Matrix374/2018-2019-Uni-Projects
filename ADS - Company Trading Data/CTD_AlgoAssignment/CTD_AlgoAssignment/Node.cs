using System;

namespace CTD_AlgoAssignment
{
    class Node<T> where T : IComparable
    {
        private T data;
        private int balanceFactor = 0;
        public Node<T> Left, Right;

        public Node(T item)
        {
            Data = item;
            Left = null;
            Right = null;
        }
        public T Data { get => data; set => data = value; }
        public int BalanceFactor { get => balanceFactor; set => balanceFactor = value; }
    }
}