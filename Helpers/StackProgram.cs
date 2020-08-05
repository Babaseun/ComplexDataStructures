using System;

namespace ComplexDataStructures.Helpers
{
    internal class StackProgram
    {
        private Stack<string> stack;  // Declaring the reference type stack
        private int SizeOfArray { get; set; }

        public StackProgram(int size)
        {
            this.stack = new Stack<string>(size); // Creates a new object or an instance of the Stack class and sets the size or capacity
            this.SizeOfArray = size; // Sets the size of array property with the input from the user
        }

        public void Run()
        {
            // Options for each complex data structure
            Console.WriteLine();
            Console.WriteLine("Choose any of the following options");
            Console.WriteLine("1. Press 1 to Push values");
            Console.WriteLine("2. Press 2 to Pop");
            Console.WriteLine("3. Press 3 to Peek");
            Console.WriteLine("4. Press 4 to Display");
            Console.WriteLine("5. Press 5 to check if the stack isEmpty");
            Console.WriteLine("6. Press 6 to get the Size of the stack");
            Console.WriteLine(" Press q to go to the main menu");

            Console.WriteLine();

            var option = Console.ReadLine(); // Gets input from the user for options
            Console.WriteLine();
            if (option == "1")
            {
                Console.WriteLine();
                Console.WriteLine("Enter " + SizeOfArray + " values separate values with commas");
                Console.WriteLine();
                var values = Console.ReadLine().Split(","); // Get values inputed by the user
                                                            // var values = data.Select(x => int.Parse(x)).ToList();

                foreach (var item in values)
                {
                    stack.Push(item); // Adds to the stack array of the stack class
                }
            }
            if (option == "2")
            {
                stack.Pop(); // Calls the POP method of the Stack class and pops the last value
            }
            if (option == "3")
            {
                Console.WriteLine("Peek Value is " + stack.Peek()); // Calls the PEEK method for the Stack class
            }
            if (option == "4")
            {
                stack.Print(); // Calls the PRINT method for the Stack class
            }
            if (option == "5")
            {
                Console.WriteLine(stack.isEmpty()); // Calls the ISEMPTY method for the Stack class
            }
            if (option == "6")
            {
                Console.WriteLine("Size is " + stack.Size()); // Calls the SIZE method for the Stack class
            }
            if (option == "q")
            {
                Program.StartProgram(); // Returns the program to the main menu
            }
        }
    }
}