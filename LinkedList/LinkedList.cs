using System;

namespace LinkedList
{
    public class LinkedList
    {
        public Node Head { get; set; }
        public Node Tail { get; set; }



        public void AddFirst(int value)
        {
            Node node = new Node(value);
            node.Next = Head;
            Head = node;
        }

        public void AddLast(int value)
        {
            Node node = new Node(value);
            node.Next = Tail;
            Tail = node;
        }

    }
}
