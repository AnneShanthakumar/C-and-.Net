public class Employee
{
    // Properties
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    // Overload the "==" operator to compare Employees by Id
    public static bool operator ==(Employee emp1, Employee emp2)
    {
        return emp1.Id == emp2.Id;
    }

    // Overload the "!=" operator for consistency
    public static bool operator !=(Employee emp1, Employee emp2)
    {
        return !(emp1 == emp2);
    }
}
