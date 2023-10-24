public class MathOperations
{
    // Method to perform math operation on an integer
    public int DoMathOperation(int number)
    {
        // For demonstration, simply square the input
        return number * number;
    }

    // Method to perform a different math operation on a decimal
    public int DoMathOperation(decimal number)
    {
        // For demonstration, double the input
        return (int)(number * 2);
    }

    // Method to perform a different math operation on a string (converted to an integer)
    public int DoMathOperation(string input)
    {
        // For demonstration, add 10 to the integer value of the string
        if (int.TryParse(input, out int number))
        {
            return number + 10;
        }
        else
        {
            // Return -1 to indicate that the string couldn't be converted to an integer
            return -1;
        }
    }
}
