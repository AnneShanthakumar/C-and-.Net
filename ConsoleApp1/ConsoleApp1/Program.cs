using System;
using System.Collections.Generic;

namespace ConsoleApp
{
    class Program
    {
        static void Main()
        {
            // Create a one-dimensional Array of strings.
            string[] stringArray = { "Apple", "Banana", "Cherry", "Peach", "Fig" };

            // Ask the user to select an index of the Array.
            Console.Write("Enter an index for the string array (0 to 4): ");
            int stringIndex = Convert.ToInt32(Console.ReadLine());
            
            // Check if the index is valid.
            if (stringIndex >= 0 && stringIndex < stringArray.Length)
            {
                // Display the string at that index on the screen.
                Console.WriteLine("Your favorite fruit is: " + stringArray[stringIndex]);
            }
            else
            {
                // Display a message for an invalid index.
                Console.WriteLine("Invalid index. This index doesn't exist in the array.");
            }

            // Create a one-dimensional Array of integers.
            int[] intArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            // Ask the user to select an index of the Array.
            Console.Write("Enter an index for the integer array (0 to 8): ");
            int intIndex = Convert.ToInt32(Console.ReadLine());

            // Check if the index is valid.
            if (intIndex >= 0 && intIndex < intArray.Length)
            {
                // Display the integer at that index on the screen.
                Console.WriteLine("Your lucky number is: " + intArray[intIndex]);
            }
            else
            {
                // Display a message for an invalid index.
                Console.WriteLine("Invalid index. This index doesn't exist in the array.");
            }

            // Create a list of strings.
            List<string> stringList = new List<string> { "Lion", "Tiger", "Elephant", "Giraffe", "Hippopotamus", "Cat", "Fish","Bird" };

            // Ask the user to select an index of the list.
            Console.Write("Enter an index for the string list (0 to 7): ");
            int listIndex = Convert.ToInt32(Console.ReadLine());

            // Check if the index is valid.
            if (listIndex >= 0 && listIndex < stringList.Count)
            {
                // Display the content at that index on the screen.
                Console.WriteLine("Your lucky Animal is : " + stringList[listIndex]);
            }
            else
            {
                // Display a message for an invalid index.
                Console.WriteLine("Invalid index. This index doesn't exist in the list.");
            }
        }
    }
}
