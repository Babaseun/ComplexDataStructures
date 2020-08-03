namespace ComplexDataStructures
{
    internal class Node
    {
        public string Element { get; set; } // Add and set Element property for the Node class
        public Node Next { get; set; } // The pointer to the next element

        public Node(string element)
        {
            this.Element = element; // Sets the property Element when an instance of class Node is called
        }
    }
}