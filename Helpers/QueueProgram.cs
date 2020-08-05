using System;

namespace ComplexDataStructures.Helpers
{
    internal class QueueProgram
    {
        private Queue<string> queue;// Declaring the reference type for queue
        private int SizeOfArray { get; set; }

        public QueueProgram(int size)
        {
            this.queue = new Queue<string>(size); // Creates a new object or an instance of the queue class and Sets the size of the queue class
            this.SizeOfArray = size; // sets the sizeOfArray property with the input from the user
        }

        public void Run()
        {
            // Options for the user
            Console.WriteLine();
            Console.WriteLine("Choose any of the following options");
            Console.WriteLine("1. Press 1 to Enqueue values");
            Console.WriteLine("2. Press 2 to Dequeue a value");
            Console.WriteLine("3. Press 3 to Display the values in the queue");
            Console.WriteLine("4. Press 4 to check if the queue isEmpty");
            Console.WriteLine("5. Press 5 to get the Size of the queue");
            Console.WriteLine(" Press q to go to the main menu");

            Console.WriteLine();
            var option = Console.ReadLine(); // Stores the option value of the user
            Console.WriteLine();
            if (option == "1")
            {
                Console.WriteLine();
                Console.WriteLine("Enter " + SizeOfArray + " values separate values with commas");
                Console.WriteLine();
                var values = Console.ReadLine().Split(","); // Stores user values and splits the values into an array
                foreach (var item in values)
                {
                    queue.Enqueue(item);//Enqueues an item
                }
            }
            if (option == "2")
            {
                queue.Dequeue();// Removes value from the front value
            }
            if (option == "3")
            {
                queue.Print(); //   Prints values in the queue
            }
            if (option == "4")
            {
                Console.WriteLine(queue.isEmpty()); // returns a boolean value if the queue is empty
            }
            if (option == "5")
            {
                Console.WriteLine("Size is " + queue.Size());// Returns the size in the queue
            }
            if (option == "q")
            {
                Program.StartProgram(); // Restarts the program
            }
        }
    }
}