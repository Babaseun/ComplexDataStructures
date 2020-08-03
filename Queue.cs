using System;

namespace ComplexDataStructures
{
    internal class Queue
    {
        private string[] array; // Stores an array of values
        private int count;// Counts the number of items in the array

        public Queue(int size)
        {
            array = new string[size]; /** Creates an new object of the string class with a
                                       * size value and assigns it to the array declared above**/
            count = -1; // Setting the count field to -1
        }

        public bool isEmpty()
        {
            return this.count == -1; // returns a boolean value if the queue is empty or not empty
        }

        public void Enqueue(string value) // Enqueues an item
        {
            this.count++; // increments the count
            this.array[this.count] = value; // sets the index of queue array with the value
        }

        public void Dequeue() // Removes the first item on the queue
        {
            string[] values = new string[this.count]; // A temporary array to store the values of the array

            int index = 0;
            for (int i = 1; i < this.array.Length; i++)
            {
                values[index] = this.array[i]; /** Re-arranging the array values by removing the first value
                                                *and assigning the next value as the first value**/
                index++;
            }
            this.array = values; // Resetting the array values to the temporary values
            this.count--; // decreasing count by one
        }

        public void Print()
        {
            Console.WriteLine("List of values in the queue"); /// Prints the values in the queue

            foreach (var item in array)
            {
                Console.WriteLine("      " + item);
            }
        }

        public int Size()
        {
            return this.count + 1; // returns the size of the queue
        }
    }
}