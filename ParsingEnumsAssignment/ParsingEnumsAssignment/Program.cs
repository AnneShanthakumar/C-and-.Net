using System;

class Program
{
    static void Main()
    {
        try
        {
            // Prompt user for input
            Console.Write("Please enter the current day of the week: ");

            // Read user input and convert it to the enum type
            DayOfWeek userInput = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), Console.ReadLine(), true);

            // Print the selected day
            Console.WriteLine($"You entered: {userInput}");
        }
        catch (Exception)
        {
            // Print error message if an exception occurs
            Console.WriteLine("Please enter an actual day of the week.");
        }
    }
}
