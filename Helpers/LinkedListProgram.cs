using System;

namespace ComplexDataStructures.Helpers
{
    internal class LinkedListProgram
    {
        private LinkedList l; // Declaring the value type

        public LinkedListProgram()
        {
            this.l = new LinkedList(); // Creating an instance or an object of the LinkedList Class  and setting the value type l
        }

        public void Run()
        {
            //Options for the users to pick from
            Console.WriteLine();
            Console.WriteLine("Choose any of the following options");
            Console.WriteLine("1. Add");
            Console.WriteLine("2. Remove");
            Console.WriteLine("3. Search");
            Console.WriteLine("4. Index");       // Menu for users to pick from
            Console.WriteLine("5. Check");
            Console.WriteLine("6. isEmpty");
            Console.WriteLine("7. Size");
            Console.WriteLine("8. InsertAt");
            Console.WriteLine("9. Display");

            Console.WriteLine();
            var option = Console.ReadLine(); // Storing the option selected by the user
            Console.WriteLine();
            if (option == "1")
            {
                Console.WriteLine();
                Console.WriteLine("Enter values separate values with commas");
                Console.WriteLine();
                var values = Console.ReadLine().Split(",");
                foreach (var item in values)
                {
                    l.Add(item); // Adds an item to the linkedList via the add method
                }
            }
            if (option == "2")
            {
                Console.WriteLine("Enter value you want to remove");
                string value = Console.ReadLine(); // Gets the value to be removed from the user
                l.Remove(value); // Calling the remove method of the linked-list class
            }
            if (option == "3")
            {
                Console.WriteLine("Enter value you want to search for");
                string value = Console.ReadLine(); // Gets the value to be search for from the user
                l.Search(value); // Calling the search method of the linked-list class
            }
            if (option == "4")
            {
                Console.WriteLine("Enter the value you want  the index of");
                string value = Console.ReadLine(); // Gets the value from the user
                Console.WriteLine("The index is " + l.IndexOf(value)); // Return the Index using the indexOf method of the linked-list class
            }
            if (option == "5")
            {
                Console.WriteLine("Enter value you want to check for"); // Gets the value to be checked for from the user
                string value = Console.ReadLine();
                Console.WriteLine(l.Check(value)); // Returns the value to be checked for if its exist
            }
            if (option == "6")
            {
                Console.WriteLine(l.isEmpty()); // Returns if the linked-list is empty via the isEmpty method of the linked-list class
            }
            if (option == "7")
            {
                Console.WriteLine("Size is " + l.Size()); // Returns the size of the linked-list
            }
            if (option == "8")
            {
                Console.WriteLine("Enter index followed by the value you want to insert");
                string[] values = Console.ReadLine().Split(",");// Gets the index and the value from the user
                l.InsertAt(int.Parse(values[0]), values[1]); /*** Sends the first index and the second index of
                                                              * the values array into the insertAt method of
                                                              * the linked list class ***/
            }
            if (option == "9")
            {
                Console.WriteLine(l.Print()); // Print all the values in the linked list
            }
            if (option == "q")
            {
                Program.StartProgram(); // Restarts the program
            }
        }
    }
}