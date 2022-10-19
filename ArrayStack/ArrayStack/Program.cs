using ArrayStack;

try
{
    var arrayStack = new ArrayStack<string>(8);

    arrayStack.Push("Player1");
    arrayStack.Push("Player2");
    arrayStack.Push("Player3");
    arrayStack.Push("Player4");
    arrayStack.Push("Player5");
    arrayStack.Push("Player6");
    arrayStack.Push("Player7");
    arrayStack.Push("Player8");
    arrayStack.Push("Player9");
    arrayStack.Push("Player10");
    arrayStack.Push("Player11");
    arrayStack.Push("Player12");


    var head = arrayStack.Pop();
    Console.WriteLine(head);   


    var head2 = arrayStack.Peek();
    Console.WriteLine(head2);   
}
catch (InvalidOperationException ex)
{
    Console.WriteLine(ex.Message);
}


Console.Read();