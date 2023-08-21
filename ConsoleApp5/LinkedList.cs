using System;

namespace ConsoleApp5
{
    public class LinkedList<T>
    {
        private Node<T> _headNode, _tailNode;

        public LinkedList(T data)
        {
            _headNode = _tailNode = new Node<T>(data);
        }

        public void Append(T data)
        {
            var newNode = new Node<T>(data);
            if (_headNode is null)
            {
                _headNode = newNode;
            }
            else
            {
                _tailNode.NextNode = newNode;
                _tailNode = newNode;
            }
        }

        public void PreAppend(T data)
        {
            var newNode = new Node<T>(data);
            if (_headNode is null)
            {
                _headNode = newNode;
            }
            else
            {
                newNode.NextNode = _headNode;
                _headNode = newNode;
            }
        }

        public void Show()
        {
            var cur = _headNode;
            while (cur != null)
            {
                PrintNode(cur);
                cur = cur.NextNode;
            }
        }

        private void PrintNode(Node<T> node)
        {
            Console.WriteLine($"data Node is :{node.Data}");
        }

        public void pop()
        {
            PrintNode(_headNode);
            _headNode = _headNode.NextNode;
        }
    }
}