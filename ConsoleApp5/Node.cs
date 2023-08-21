namespace ConsoleApp5
{
    public class Node<T>
    {
        public T Data;

        public Node(T data)
        {
            Data = data;
            NextNode = null;
        }

        public Node<T> NextNode { get; set; }
    }
}