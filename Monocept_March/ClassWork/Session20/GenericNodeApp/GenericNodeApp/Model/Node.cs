using System;

namespace GenericNodeApp.Model
{
    internal class Node<E>
    {
        public E Data { get; set; }
        public Node<E> Next { get; set; }
    }
}
