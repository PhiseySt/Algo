using DoublyLinkedList;

var linkedList = new DoublyLinkedList<string>();

linkedList.Add("Player1");
linkedList.Add("Player2");
linkedList.Add("Player3");
linkedList.AddFirst("Player0");
foreach (var player in linkedList)
{
    Console.WriteLine(player);
}

linkedList.Remove("Player3");
Console.WriteLine("");

foreach (var player in linkedList.BackEnumerator())
{
    Console.WriteLine(player);
}