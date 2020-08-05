using System;

namespace ComplexDataStructures.Helpers
{
    internal class LinkedListProgram
    {
        private LinkedList<string> linkedList; // Declaring the reference type

        public LinkedListProgram()
        {
            this.linkedList = new LinkedList<string>(); // Creating an instance or an object of the LinkedList Class with reference type string
        }

        public void Run()
        {
            // Options for the users to pick from
            Console.WriteLine();
            Console.WriteLine("Choose any of the following options");
            Console.WriteLine("1. Press 1 to Add values");
            Console.WriteLine("2. Press 2 to Remove");
            Console.WriteLine("3. Press 3 to Search");
            Console.WriteLine("4. Press 4 to get the Index of a value");       // Menu for users to pick from
            Console.WriteLine("5. Press 5 to Check for a value if it exists");
            Console.WriteLine("6. Press 6 to Check if the linkedList isEmpty");
            Console.WriteLine("7. Press 7 to get the Size of the linkedList");
            Console.WriteLine("8. Press 8 to  InsertAt a particular index");
            Console.WriteLine("9. Press 9 to Display the LinkedList");
            Console.WriteLine("Press q to go to the main menu");

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
                    linkedList.Add(item); // Adds an item to the linkedList via the add method
                }
            }
            if (option == "2")
            {
                Console.WriteLine("Enter value you want to remove");
                string value = Console.ReadLine(); // Gets the value to be removed from the user
                linkedList.Remove(value); // Calling the remove method of the linked-list class to remove a value
            }
            if (option == "3")
            {
                Console.WriteLine("Enter value you want to search for");
                string value = Console.ReadLine(); // Gets the value to be search for from the user
                linkedList.Search(value); // Calling the search method of the linked-list class and passing the value to be search for
            }
            if (option == "4")
            {
                Console.WriteLine("Enter the value you want the index of");
                string value = Console.ReadLine(); // Gets the value from the user
                Console.WriteLine("The index is " + linkedList.IndexOf(value)); // Return the Index using the indexOf method of the linked-list class
            }
            if (option == "5")
            {
                Console.WriteLine("Enter value you want to check for"); // Gets the value to be checked for from the user
                string value = Console.ReadLine();
                Console.WriteLine(linkedList.Check(value)); // Returns the value to be checked for if its exist
            }
            if (option == "6")
            {
                Console.WriteLine(linkedList.isEmpty()); // Returns a boolean if the linked-list is empty via the isEmpty method of the linked-list class
            }
            if (option == "7")
            {
                Console.WriteLine("Size is " + linkedList.Size()); // Returns the size of the linked-list
            }
            if (option == "8")
            {
                Console.WriteLine("Enter index followed by the value you want to insert separate value with commas");
                string[] values = Console.ReadLine().Split(",");// Gets the index and the value from the user
                linkedList.InsertAt(int.Parse(values[0]), values[1]); /*** Sends the first index and the second index of
                                                              * the values array into the insertAt method of
                                                              * the linked list class ***/
            }
            if (option == "9")
            {
                Console.WriteLine(linkedList.Print()); // Print all the values in the linked list
            }
            if (option == "q")
            {
                Program.StartProgram(); // Restarts the program
            }
        }
    }
}