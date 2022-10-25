using CircularLinkedList;

var circularList = new CircularLinkedList<string>
{
    "Player1",
    "Player2",
    "Player3",
    "Player4"
};

foreach (var player in circularList)
{
    Console.WriteLine(player);
}

circularList.Remove("Player1");
Console.WriteLine();
foreach (var item in circularList)
{
    Console.WriteLine(item);
}