using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main()
        {
            // Instantiate the MathOperations class
            MathOperations mathOperations = new MathOperations();

            // Call the first method with an integer
            int result1 = mathOperations.DoMathOperation(5);
            Console.WriteLine("Result 1: " + result1);

            // Call the second method with a decimal
            int result2 = mathOperations.DoMathOperation(3.5m);
            Console.WriteLine("Result 2: " + result2);

            // Call the third method with a string (which can be converted to an integer)
            int result3 = mathOperations.DoMathOperation("7");
            Console.WriteLine("Result 3: " + result3);
        }
    }
}
