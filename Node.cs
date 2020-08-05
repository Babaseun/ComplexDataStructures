namespace ComplexDataStructures
{
    internal class Node<T>
    {
        public T Element { get; set; } // Add and set Element property for the Node class
        public Node<T> Next { get; set; } // The pointer to the next element

        public Node(T element)
        {
            this.Element = element; // Sets the property Element when an instance of class Node is called
        }
    }
}