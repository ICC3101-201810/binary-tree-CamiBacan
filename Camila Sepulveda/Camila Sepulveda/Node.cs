using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Camila_Sepulveda
{
    class Node<T>
    {
        T data = default(T);
        Node<T> left = default(Node<T>);
        Node<T> right = default(Node<T>);

        /*public Node(T data, T leftNode, Node<T> rightNode)
        {
            this.data = data;
            left = leftNode;
            right = rightNode;
        }*/
        public Node(T node)
        {
            data = node;
            left = null;
            right = null;
        }

        public Node()
        {
            data = default(T);
            left = null;
            right = null;
        }

        public T GetData()
        {
            return data;
        }
        

        public Node<T> GetLeft()
        {
            return left;
        }

        public Node<T> GetRight()
        {
            return right;
        }

        public LinkedListNode<T> AddData(T obj)
        {
            LinkedListNode<T> dataList = new LinkedListNode<T>(obj);
            return dataList;
        }

         
    }          
    
}
