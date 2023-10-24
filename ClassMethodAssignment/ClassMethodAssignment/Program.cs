
class Program
{
    static void Main()
    {
        // Instantiate the MathOperations class
        MathOperations mathOperations = new MathOperations();

        // Have the user enter a number
        Console.Write("Enter a number: ");
        int userInput = Convert.ToInt32(Console.ReadLine());

        // Call the void method on the entered number
        mathOperations.DivideByTwo(userInput);

        // Call the method with output parameters
        int outputResult;
        mathOperations.MultiplyByTwo(10, out outputResult);
        Console.WriteLine($"Result (output parameter method): {outputResult}");

        // Call the overloaded method
        mathOperations.MultiplyByTwo(3.5);
    }
}
