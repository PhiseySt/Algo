namespace PoiskVShirinu;

public class BreadthFirstAlgorithm
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
        var q = new Queue<Employee>();
        var s = new HashSet<Employee>();
        q.Enqueue(root);
        s.Add(root);

        while (q.Count > 0)
        {
            var e = q.Dequeue();
            if (e.Name == nameToSearchFor)
                return e;
            foreach (var friend in e.Employees)
            {
                if (!s.Contains(friend))
                {
                    q.Enqueue(friend);
                    s.Add(friend);
                }
            }
        }
        return null;
    }

    public void Traverse(Employee root)
    {
        var traverseOrder = new Queue<Employee>();

        var q = new Queue<Employee>();
        var s = new HashSet<Employee>();
        q.Enqueue(root);
        s.Add(root);

        while (q.Count > 0)
        {
            var e = q.Dequeue();
            traverseOrder.Enqueue(e);

            foreach (var emp in e.Employees)
            {
                if (!s.Contains(emp))
                {
                    q.Enqueue(emp);
                    s.Add(emp);
                }
            }
        }

        while (traverseOrder.Count > 0)
        {
            var e = traverseOrder.Dequeue();
            Console.WriteLine(e);
        }
    }
}