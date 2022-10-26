using CircularDoublyLinkedList;

var circularDoublyLinkedList = new CircularDoublyLinkedList<string>
{
    "Player1",
    "Player2",
    "Player3",
    "Player4"
};

foreach (var player in circularDoublyLinkedList)
{
    Console.WriteLine(player);
}

circularDoublyLinkedList.Remove("Player2");
Console.WriteLine();
foreach (var player in circularDoublyLinkedList)
{
    Console.WriteLine(player);
}