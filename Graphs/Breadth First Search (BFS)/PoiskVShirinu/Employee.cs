namespace PoiskVShirinu;

public class Employee
{
    public Employee(string name)
    {
        Name = name;
    }

    public string Name { get; set; }
    public List<Employee> Employees { get; } = new();

    public void IsEmployeeOf(Employee p)
    {
        Employees.Add(p);
    }

    public override string ToString()
    {
        return Name;
    }
}