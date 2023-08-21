using System;

namespace ConsoleApp5
{
    public class stack<T>
    {
        private Node<T> _headNode;

        public stack(T data)
        {
            _headNode = new Node<T>(data);
        }

        private void PrintNode(Node<T> node)
        {
            Console.WriteLine($"data node is {node.Data}");
        }

        public void Append(T data)
        {
            var newNode = new Node<T>(data);
            if (_headNode == null)
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
    }
}