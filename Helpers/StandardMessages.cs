using System;

namespace ComplexDataStructures.Helpers
{
    internal class StandardMessages
    {
        public static void MainMenu()
        {
            Console.WriteLine("Welcome to Complex Data Structures\n");
            Console.WriteLine("Choose one of the following options\n" +
                "              1. Press 1 for Stack \n" +                                      //Main menu options for users to choose from
                "              2. Press 2 for Queue\n" +
                "              3. Press 3 LinkedList\n");
        }

        public static int Size()
        {
            Console.WriteLine("How many values do you want to add");
            var size = int.Parse(Console.ReadLine());

            return size;
        }
    }
}