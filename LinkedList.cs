using System;

namespace ComplexDataStructures
{
    internal class LinkedList<T>
    {
        public Node<T> Head = null; // Sets the head of a LinkedList with a node type with an initial value of null
        private int length = 0;// The length of the values added to the linkedList

        public void Add(T value)
        {
            var node = new Node<T>(value);/** Creates an object of the node class with a required value passed in
                                           * of generic type T **/

            if (this.Head == null)
            {
                this.Head = new Node<T>(value); // Adds the head of the linked-list when it is null
            }
            else
            {
                var current = this.Head; // When the head is not null assign the head to current

                while (current.Next != null) //Looping through the linked-list till it is null
                {
                    current = current.Next;// Passing the value of next to current
                }
                current.Next = node; // Sets the null value to the new node
            }
            this.length++; // Increments the length by one
        }

        public void Remove(T value)
        {
            Node<T> prevNode = new Node<T>(value);/** Creates a temporary node to store previous
                                                   * nodes in the linkedList **/

            var current = this.Head; // Gets the head of the linked-list

            while (!current.Element.Equals(value)) /** When the current element is not equal
                                                    * to the value to be removed
                                                    **/
            {
                prevNode = current;// Assigns the current value to the previousNode
                current = current.Next; // Resets the current value to the next node
            }
            prevNode.Next = current.Next; //Excludes the value to be removed by joining the prevNode.Next to the current.Next
            this.length--;// Decreasing the length of the linked-list
        }

        public void Search(T value)
        {
            try
            {
                var current = this.Head; // Starts from the head and assigns the value to current

                while (!current.Element.Equals(value)) // While the value is not the value i am looking for
                {
                    current = current.Next; // Re assigns current to the next value in the linked-list
                }
                Console.WriteLine("Found " + current.Element.ToString()); // returns the found value
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("Value " + value + " was not added");// returns a null reference exception if the value does not exist
            }
        }

        public int IndexOf(T value)
        {
            try
            {
                var index = 0; // Starts the index from zero
                var current = this.Head;// Assigns the current list to the current variable
                while (!current.Element.Equals(value)) // While the current element is not the value i am looking for
                {
                    current = current.Next; // Re assign current to the next element
                    index++;// Increments the index till it is finally found
                }
                return index; // returns the index after the value has been found
            }
            catch (NullReferenceException)
            {
                return -1; // Returns a null exception if the value does not exist
            }
        }

        public bool Check(T value) // Check if the values exists
        {
            try
            {
                var current = this.Head;
                while (!current.Element.Equals(value))                  /** While the current element is not
                                                                    * the value i am looking for **/
                {
                    current = current.Next; /* Re-assigns the current to the next element in the
                                             * LinkedList*/
                }
                return true;
            }
            catch (NullReferenceException)
            {
                return false; // returns false if there is a null reference exception
            }
        }

        public bool isEmpty()
        {
            return this.length == 0; // returns a boolean value if the length of the list is 0 or greater than 0
        }

        public int Size()
        {
            return this.length;// Returns the size of the linked-list
        }

        public void InsertAt(int index, T value) // Inserting at a particular index in the linked-list
        {
            int position = 0;

            var current = this.Head; //Holds the linked-list from the head
            Node<T> prevNode = new Node<T>(value);
            var node = new Node<T>(value);

            if (index == 0) // if the index of the replacement node is 0
            {
                this.Head = node; // Sets the Head of the linked-list to the replacement node
                node.Next = current;// sets the replacement node.next all the values previously in the current node
            }
            else
            {
                while (position < index) // if we are not replacing the head node
                {
                    position++; // increments  the position to the index of the replacement node
                    prevNode = current; // Assigning the current node to the previous node
                    current = current.Next;// Setting current to the next element in the linked-list
                }
                node.Next = current; //sets the node.next to the current
                prevNode.Next = node; // previous node.next to the node
            }
            this.length++;// increments length by one
        }

        public string Print()
        {
            var str = "The Head >>>>> => ";
            var current = this.Head;

            while (current != null)           // prints the values in the linked-list
            {
                str += current.Element + " <= ";
                current = current.Next;
            }
            str += "<<<<< The Tail";
            return str;
        }
    }
}