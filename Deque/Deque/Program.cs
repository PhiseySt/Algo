using Deque;

var playerDeque = new Deque<string>();
playerDeque.AddFirst("Player1");
playerDeque.AddLast("Player2");
playerDeque.AddLast("Player3");

foreach (var player in playerDeque)
    Console.WriteLine(player);

Console.WriteLine();

var removedPlayer = playerDeque.RemoveFirst();
Console.WriteLine(removedPlayer);

Console.WriteLine();

foreach (var player in playerDeque)
    Console.WriteLine(player);