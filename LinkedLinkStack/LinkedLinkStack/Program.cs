using LinkedLinkStack;

var linkedLinkStack = new LinkedLinkStack<string>();

linkedLinkStack.Push("Player1");
linkedLinkStack.Push("Player2");
linkedLinkStack.Push("Player3");
linkedLinkStack.Push("Player4");

foreach (var player in linkedLinkStack)
{
    Console.WriteLine(player);
}
Console.WriteLine();

var header = linkedLinkStack.Peek();
Console.WriteLine(header);
Console.WriteLine();

header = linkedLinkStack.Pop();
foreach (var player in linkedLinkStack)
{
    Console.WriteLine(player);
}