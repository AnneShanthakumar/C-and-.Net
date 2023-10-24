class Program
{
    static void Main()
    {
        // Create two Employee objects
        Employee emp1 = new Employee
        {
            Id = 1,
            FirstName = "Dave",
            LastName = "Doe"
        };

        Employee emp2 = new Employee
        {
            Id = 2,
            FirstName = "Jane",
            LastName = "Doe"
        };

        // Compare employees using overloaded operators
        bool areEqual = (emp1 == emp2);

        // Display the result
        Console.WriteLine($"Employees are equal: {areEqual}");
    }
}
