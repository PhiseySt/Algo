using LinkedListQueue;

var linkedListQueue = new LinkedListQueue<string>();
linkedListQueue.Enqueue("Player1");
linkedListQueue.Enqueue("Player2");
linkedListQueue.Enqueue("Player3");
linkedListQueue.Enqueue("Player4");

foreach (var player in linkedListQueue)
    Console.WriteLine(player);
Console.WriteLine();

var firstItem = linkedListQueue.Dequeue();
Console.WriteLine(firstItem);
Console.WriteLine();

linkedListQueue.Enqueue("Player5");
foreach (var player in linkedListQueue)
    Console.WriteLine(player);