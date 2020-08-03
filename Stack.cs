using System;

namespace ComplexDataStructures
{
    internal class Stack
    {
        private string[] array; // Stores an array of values

        private int size; // size of the array

        public Stack(int size)
        {
            array = new string[size];  // new object of the stack array

            size = 0; // size of the array
        }

        public bool isEmpty()
        {
            return this.size == 0; // returns a boolean value if array is empty
        }

        public void Push(string value)
        {
            array[this.size++] = value; // Adds to the array and increments the size
        }

        public void Pop()
        {
            try
            {
                this.size--; // Decreasing the size the array is popped
                string[] values = new string[this.size];// Temporary storage of all the values in the array

                for (int i = 0; i < this.array.Length - 1; i++)
                {
                    values[i] = this.array[i]; // Adds the values in the array to the temporary storage
                }

                this.array = values; // Reset values in the array to the temporary storage array
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

        public string Peek()
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