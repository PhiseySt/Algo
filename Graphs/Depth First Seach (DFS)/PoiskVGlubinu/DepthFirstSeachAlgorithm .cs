namespace PoiskVGlubinu;

public class DepthFirstSeachAlgorithm
{
    public Employee BuildEmployeeGraph()
    {
        var Eva = new Employee("Eva");
        var Sophia = new Employee("Sophia");
        var Brian = new Employee("Brian");
        Eva.IsEmployeeOf(Sophia);
        Eva.IsEmployeeOf(Brian);

        var Lisa = new Employee("Lisa");
        var Tina = new Employee("Tina");
        var John = new Employee("John");
        var Mike = new Employee("Mike");
        Sophia.IsEmployeeOf(Lisa);
        Sophia.IsEmployeeOf(John);
        Brian.IsEmployeeOf(Tina);
        Brian.IsEmployeeOf(Mike);

        return Eva;
    }

    public Employee? Search(Employee root, string nameToSearchFor)
    {
        if (nameToSearchFor == root.Name)
            return root;

        Employee? personFound = null;
        foreach (var t in root.Employees)
        {
            personFound = Search(t, nameToSearchFor);
            if (personFound != null)
                break;
        }
        return personFound;
    }

    public void Traverse(Employee root)
    {
        Console.WriteLine(root.Name);
        foreach (var t in root.Employees)
        {
            Traverse(t);
        }
    }
}