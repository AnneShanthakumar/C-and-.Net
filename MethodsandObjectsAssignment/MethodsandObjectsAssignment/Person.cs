using System;

// Define the Person class
public class Person
{
    // Properties of the Person class
    public string FirstName { get; set; }
    public string LastName { get; set; }

    // Void method to say the name
    public void SayName()
    {
        Console.WriteLine($"Name: {FirstName} {LastName}");
    }
}



