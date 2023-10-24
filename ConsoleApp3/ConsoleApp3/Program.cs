using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main()
        {
            // Ask the user for a number
            Console.Write("Enter a number: ");
            int userInput = Convert.ToInt32(Console.ReadLine());

            // Create an instance of MathOperations
            MathOperations mathOperations = new MathOperations();

            // Call each method and display the returned value
            int doubledNumber = mathOperations.DoubleNumber(userInput);
            Console.WriteLine($"Double of {userInput}: {doubledNumber}");

            int squaredNumber = mathOperations.SquareNumber(userInput);
            Console.WriteLine($"Square of {userInput}: {squaredNumber}");

            int numberPlusTen = mathOperations.AddTen(userInput);
            Console.WriteLine($"{userInput} + 10 = {numberPlusTen}");
        }
    }
}
