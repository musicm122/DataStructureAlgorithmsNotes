using System.Collections.Generic;

namespace Models
{
    public class Node<T>
    {
        public Node<T> Parent { get; set; }
        public T Data { get; set; }
        public List<Node<T>> Neighbors { get; set; }
        public Node()
        {
        }
        public Node(T data) : this(data, null) { }
        public Node(T data, List<Node<T>> neighbors)
        {
            this.Data = data;
            this.Neighbors = neighbors;
        }
    }
}