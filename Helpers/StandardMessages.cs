using System;
using System.Collections.Generic;
using System.Text;

namespace ComplexDataStructures.Helpers
{
    internal class StandardMessages
    {
        public static void MainMenu()
        {
            Console.WriteLine("Welcome to Complex Data Structures\n");
            Console.WriteLine("Choose one of the following options\n" +
                "              1. Stack \n" +                                      //Main menu options for users to choose from
                "              2. Queue\n" +
                "              3. LinkedList\n" +
                "              4. Press q to go to the main menu");
        }

        public static int Values()
        {
            Console.WriteLine("How many values do you want to add");
            var value = int.Parse(Console.ReadLine());

            return value;
        }
    }
}