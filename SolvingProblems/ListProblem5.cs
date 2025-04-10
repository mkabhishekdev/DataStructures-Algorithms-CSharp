/*

5. Custom Sorting of a List of Objects
Problem:
Sort a list of custom objects by a property value (e.g., salary).

Input:
class Employee
{
    public string Name { get; set; }
    public int Salary { get; set; }
}

List<Employee> employees = new List<Employee>
{
    new Employee { Name = "Alice", Salary = 50000 },
    new Employee { Name = "Bob", Salary = 40000 },
    new Employee { Name = "Charlie", Salary = 60000 }
};


Expected Output:
Bob - 40000
Alice - 50000
Charlie - 60000


*/