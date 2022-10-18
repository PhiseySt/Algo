var linkedList = new LinkedList.LinkedList<string>
{
    "Player1",
    "Player2",
    "Player3",
    "Player4"
};

foreach (var player in linkedList)
{
    Console.WriteLine(player);
}

linkedList.AddFirst("Player0");
linkedList.Remove("Player3");
linkedList.Add("Player5");

Console.WriteLine();
foreach (var player in linkedList)
{
    Console.WriteLine(player);
}