using System;
using System.Collections.Generic;

namespace ConsoleApp
{
    class Program
    {
        static void Main()
        {
            // Create a list of integers.
            List<int> numbers = new List<int> { 10, 20, 30, 40, 50 };

            try
            {
                // Ask the user for a number to divide each number in the list by.
                Console.Write("Enter a number to divide by: ");
                string userInput = Console.ReadLine();
                int divisor = Convert.ToInt32(userInput); // Convert user input to an integer

                // Write a loop that takes each integer in the list, divides it, and displays the result.
                foreach (int number in numbers)
                {
                    int result = number / divisor;
                    Console.WriteLine($"{number} / {divisor} = {result}");
                }
            }
            catch (FormatException ex)
            {
                // Handle the case where the user enters a non-integer input.
                Console.WriteLine("Error: Invalid input. Please enter a valid integer.");
                Console.WriteLine(ex.Message);
            }
            catch (DivideByZeroException ex)
            {
                // Handle the case where the user tries to divide by zero.
                Console.WriteLine("Error: Cannot divide by zero.");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                // This code will always execute after the try/catch block.
                Console.WriteLine("Program has emerged from the try/catch block.");
            }
        }
    }
}
