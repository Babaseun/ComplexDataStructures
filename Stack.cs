using System;

namespace ComplexDataStructures
{
    internal class Stack<T>
    {
        private T[] array; // Stores an array of values of generic type T

        private int size; // size of the array

        public Stack(int size)
        {
            array = new T[size];  // De clearing a new object of generic type T and the size
        }

        public bool isEmpty()
        {
            return this.size == 0; // returns a boolean value if array is empty
        }

        public void Push(T value)
        {
            array[this.size++] = value; // Adds value to the array and increments the size by 1
        }

        public void Pop() // Pops values from the back of the array
        {
            try
            {
                this.size--; // Decreasing the size the array as values are  popped off
                T[] values = new T[this.size];// Temporary storage of all the values in the array of generic type T

                for (int i = 0; i < this.array.Length - 1; i++)
                {
                    values[i] = this.array[i]; // Adds the values in the array to the temporary storage
                }

                this.array = values; // Resets or re-assign the values in the array to the temporary storage array
            }
            catch (IndexOutOfRangeException e) // Catches error when the index is out of range
            {
                Console.WriteLine("array is Empty" + e);
            }
        }

        public int Size()
        {
            return size; // Returns the size of the array
        }

        public T Peek()
        {
            return this.array[this.size - 1]; //Returns the last value
        }

        public void Print()
        {
            Console.WriteLine("List of values in the stack");
            foreach (var item in array)                                 // Prints the values
            {
                Console.WriteLine("       " + item);
            }
        }
    }
}