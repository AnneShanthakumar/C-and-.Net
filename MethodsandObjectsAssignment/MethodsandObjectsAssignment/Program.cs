class Program
{
    static void Main()
    {
        // Instantiate and initialize an Employee object
        Employee employee = new Employee
        {
            FirstName = "Anne",
            LastName = "Shan",
            Id = 12345
        };

        // Call the SayName() method of the Person class (inherited by Employee)
        employee.SayName();
    }
}