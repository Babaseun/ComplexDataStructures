using ComplexDataStructures.Helpers;
using System;

namespace ComplexDataStructures
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Program.StartProgram(); // Starts the program by calling the static method STARTPROGRAM in the program class
        }

        public static void StartProgram()
        {
            while (true)
            {
                StandardMessages.MainMenu();

                var option = Console.ReadLine();// stores the option value of the user
                Console.WriteLine();

                if (option == "1")
                {
                    var size = StandardMessages.Values();
                    StackProgram stack = new StackProgram(size); // Creates an instance of the stackProgram class
                    while (true) // A continuous loop for the stack program class
                    {
                        stack.Run(); // Runs the RUN Method in the stack program class
                    }
                }

                if (option == "2")
                {
                    var size = StandardMessages.Values();
                    QueueProgram queue = new QueueProgram(size); // Creates an object of the QueueProgram class
                    while (true) // A continuous loop for the queue program class
                    {
                        {
                            queue.Run(); // Runs the RUN Method in the queue Program class
                        }
                    }
                }

                if (option == "3")
                {
                    LinkedListProgram linkedList = new LinkedListProgram(); // Created an instance of the LinkedListProgram class
                    while (true) // A continuous loop for the linkedList program class
                    {
                        {
                            linkedList.Run(); // Runs the RUN Method in the linkedListProgram class
                        }
                    }
                }
            }
        }
    }
}