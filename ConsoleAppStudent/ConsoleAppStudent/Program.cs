﻿using ConsoleAppStudent;

class Program
{
    static void Main(string[] args)
    {
        using (var context = new SchoolContext())
        {
            var student = new Student
            {
                FirstName = "John",
                LastName = "Doe"
            };

            context.Students.Add(student);
            context.SaveChanges();
        }
    }
}
