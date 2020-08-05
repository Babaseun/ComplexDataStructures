using System;

namespace ComplexDataStructures
{
    internal class Queue<T>
    {
        private T[] array; // Stores an array of values of generic type T
        private int count;// Counts the number of items in the array

        public Queue(int size)
        {
            array = new T[size]; /** Creates a new object of generic type T of
                                   * size value and assigns it to the array declared above
                                   ***/
            count = -1; // Setting the count field to -1 because no value has been added
        }

        public bool isEmpty()
        {
            return this.count == -1; // returns a boolean value if the queue is empty or not empty
        }

        public void Enqueue(T value) // Enqueues an item of type T
        {
            this.count++; // increments the count by 1
            this.array[this.count] = value; // Enqueues values by index
        }

        public void Dequeue() // Removes the first item on the queue
        {
            T[] values = new T[this.count]; // A temporary array to store the values of the array of generic type T

            int index = 0;

            for (int i = 1; i < this.array.Length; i++)
            {
                values[index] = this.array[i]; /** Re-arranging the array values by removing the first value
                                                * and assigning the next value as the first value which is re-assigned
                                                * a new index which is 0 **/
                index++;// Increments the index by 1
            }
            this.array = values; // Resetting the array values to the temporary array values
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