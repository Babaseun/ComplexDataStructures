﻿using System;

namespace ComplexDataStructures
{
    internal class LinkedList
    {
        public Node Head { get; set; } // Sets the head of a LinkedList
        private int length = 0;// The length of the values added to the linkedList

        public void Add(string value)
        {
            var node = new Node(value);// Creates an object of the node class

            if (this.Head == null)
            {
                this.Head = new Node(value); // Adds the head of the linked-list when it is null
            }
            else
            {
                var current = this.Head;// When the head is not null

                while (current.Next != null) //Looping through the linked-list till it is null
                {
                    current = current.Next;// Passing the value of next to current
                }
                current.Next = node; // Sets the null value to the new node
            }
            this.length++; // Increments the length by one
        }

        public void Remove(string value)
        {
            Node prevNode = new Node("");// Creates an empty node

            var current = this.Head; // Gets the head of the linked-list

            while (current.Element != value)
            {
                prevNode = current;// Assigns the current value to the previousNode
                current = current.Next; // Resets the current value to the next node
            }
            prevNode.Next = current.Next; //Excludes the value  i want to remove by joining the prevNode.Next to the current.Next
            this.length--;// Decrease the length of the linked-list
        }

        public void Search(string value)
        {
            try
            {
                var current = this.Head; // Starts from the head and assigns the value to current

                while (current.Element != value) // While the value is not the value i am looking for
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

        public int IndexOf(string value)
        {
            try
            {
                var index = 0; // Starts the index from zero
                var current = this.Head;// Assigns the current list to current
                while (current.Element != value)// While the current element is not the value i am looking for
                {
                    current = current.Next; // Re assign current to the next element
                    index++;// Increments the index till it is finally found
                }
                return index; // returns the index
            }
            catch (NullReferenceException)
            {
                return -1; // Returns a null exception if the value does not exist
            }
        }

        public bool Check(string value) // Check if the values exists
        {
            try
            {
                var current = this.Head;
                while (current.Element != value)
                {
                    current = current.Next;
                }
                return true;
            }
            catch (NullReferenceException)
            {
                return false;
            }
        }

        public bool isEmpty()
        {
            return this.length == 0;
        }

        public int Size()
        {
            return this.length;
        }

        public void InsertAt(int index, string value)
        {
            int position = 0;
            var current = this.Head;
            Node prevNode = new Node("");
            var node = new Node(value);

            if (index == 0)
            {
                this.Head = node;
                node.Next = current;
            }
            else
            {
                while (position < index)
                {
                    position++;
                    prevNode = current;
                    current = current.Next;
                }
                node.Next = current;
                prevNode.Next = node;
            }
            this.length++;
        }

        public string Print()
        {
            var str = "The Head >>>>> => ";
            var current = this.Head;

            while (current != null)
            {
                str += current.Element + " <= ";
                current = current.Next;
            }
            str += "<<<<< The Tail";
            return str;
        }
    }
}