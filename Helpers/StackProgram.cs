using System;

namespace ComplexDataStructures.Helpers
{
    internal class StackProgram
    {
        private Stack s; // Declaring the value type

        public StackProgram(int size)
        {
            this.s = new Stack(size);// Creates a new object or an instance and sets the size of the stack class
        }

        public void Run()
        {
            // Options for each complex data structure
            Console.WriteLine();
            Console.WriteLine("Choose any of the following options");
            Console.WriteLine("1. Push");
            Console.WriteLine("2. Pop");
            Console.WriteLine("3. Peek");
            Console.WriteLine("4. Display");
            Console.WriteLine("5. isEmpty");
            Console.WriteLine("6. Size");
            Console.WriteLine();

            var option = Console.ReadLine(); // Gets input from the user for options
            Console.WriteLine();
            if (option == "1")
            {
                Console.WriteLine();
                Console.WriteLine("Enter values separate values with commas");
                Console.WriteLine();
                var values = Console.ReadLine().Split(","); // Get values inputed by the user
                foreach (var item in values)
                {
                    s.Push(item); // Adds to the stack class
                }
            }
            if (option == "2")
            {
                s.Pop(); // Calls the POP method for the Stack class
            }
            if (option == "3")
            {
                Console.WriteLine("Peek Value is " + s.Peek()); // Calls the PEEK method for the Stack class
            }
            if (option == "4")
            {
                s.Print(); // Calls the PRINT method for the Stack class
            }
            if (option == "5")
            {
                Console.WriteLine(s.isEmpty()); // Calls the ISEMPTY method for the Stack class
            }
            if (option == "6")
            {
                Console.WriteLine("Size is " + s.Size()); // Calls the SIZE method for the Stack class
            }
            if (option == "q")
            {
                Program.StartProgram(); // Returns the program to the main menu
            }
        }
    }
}