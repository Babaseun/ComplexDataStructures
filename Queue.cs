using System;

namespace ComplexDataStructures
{
    internal class Queue
    {
        private string[] array;
        private int count;

        public Queue(int size)
        {
            array = new string[size];
            count = -1;
        }

        public bool isEmpty()
        {
            return this.count == -1;
        }

        public void Enqueue(string value)
        {
            this.count++;
            this.array[this.count] = value;
        }

        public void Dequeue()
        {
            string[] values = new string[this.count];

            int index = 0;
            for (int i = 1; i < this.array.Length; i++)
            {
                values[index] = this.array[i];
                index++;
            }
            this.array = values;
            this.count--;
        }

        public void Print()
        {
            Console.WriteLine("List of values in the queue");

            foreach (var item in array)
            {
                Console.WriteLine("      " + item);
            }
        }

        public int Size()
        {
            return this.count + 1;
        }
    }
}