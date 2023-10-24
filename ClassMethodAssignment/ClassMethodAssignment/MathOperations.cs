using System;

public class MathOperations
{
    // Void method that outputs an integer (dividing the data passed by 2)
    public void DivideByTwo(int number)
    {
        int result = number / 2;
        Console.WriteLine($"Result: {result}");
    }

    // Method with output parameters
    public void MultiplyByTwo(int input, out int result)
    {
        result = input * 2;
    }

    // Overloaded method
    public void MultiplyByTwo(double input)
    {
        double result = input * 2;
        Console.WriteLine($"Result (overloaded method): {result}");
    }
}
