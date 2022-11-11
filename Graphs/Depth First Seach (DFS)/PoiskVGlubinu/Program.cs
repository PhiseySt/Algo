using PoiskVGlubinu;

DepthFirstSeachAlgorithm b = new ();
var root = b.BuildEmployeeGraph();
Console.WriteLine("Traverse Graph\n------");
b.Traverse(root);

Console.WriteLine("\nSearch in Graph\n------");
var e = b.Search(root, "Eva");
Console.WriteLine(e == null ? "Employee not found" : e.Name);
e = b.Search(root, "Brian");
Console.WriteLine(e == null ? "Employee not found" : e.Name);
e = b.Search(root, "Soni");
Console.WriteLine(e == null ? "Employee not found" : e.Name);