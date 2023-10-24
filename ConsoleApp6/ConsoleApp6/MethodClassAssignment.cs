
class Program
{
    static void Main()
    {
        // Instantiate the MathOperations class
        MathOperations mathOperations = new MathOperations();

        // Call the method in the class, passing in two numbers
        Console.WriteLine("Calling method with two numbers:");
        mathOperations.PerformMathOperation(5, 7);

        // Call the method in the class, specifying the parameters by name
        Console.WriteLine("\nCalling method with named parameters:");
        mathOperations.PerformMathOperation(number1: 10, number2: 3);
    }
}
