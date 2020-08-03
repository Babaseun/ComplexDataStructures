using System;

namespace ComplexDataStructures.Helpers
{
    internal class QueueProgram
    {
        private Queue q;// Declaring the value type

        public QueueProgram(int size)
        {
            this.q = new Queue(size); // Creates a new object or an instance of the queue class and Sets the size of the queue class
        }

        public void Run()
        {
            // Options for the user
            Console.WriteLine();
            Console.WriteLine("Choose any of the following options");
            Console.WriteLine("1. Enqueue");
            Console.WriteLine("2. Dequeue");
            Console.WriteLine("3. Display");
            Console.WriteLine("4. isEmpty");
            Console.WriteLine("5. Size");
            Console.WriteLine("NOTE: " + "Only 10 values can be added");

            Console.WriteLine();
            var option = Console.ReadLine(); // Stores the option value of the user
            Console.WriteLine();
            if (option == "1")
            {
                Console.WriteLine();
                Console.WriteLine("Enter values separate values with commas");
                Console.WriteLine();
                var values = Console.ReadLine().Split(","); // Stores user values and splits the values into an array
                foreach (var item in values)
                {
                    q.Enqueue(item);//Enqueues an item
                }
            }
            if (option == "2")
            {
                q.Dequeue();// Removes value from the front value
            }
            if (option == "3")
            {
                q.Print(); //   Prints values in the queue
            }
            if (option == "4")
            {
                Console.WriteLine(q.isEmpty()); // returns a boolean value if the queue is empty
            }
            if (option == "5")
            {
                Console.WriteLine("Size is " + q.Size());// Returns the size in the queue
            }
            if (option == "q")
            {
                Program.StartProgram(); // Restarts the program
            }
        }
    }
}