using System.Collections;

namespace LinkedLinkStack;

public class LinkedLinkStack<T> : IEnumerable<T>
{
    private Node<T>? _head;
    public int Count { get; private set; }

    public bool IsEmpty() => Count == 0;

    public void Push(T item)
    {
        var node = new Node<T>(item);
        node.Next = _head;
        _head = node;
        Count++;
    }
    public T Pop()
    {
        if (IsEmpty()) throw new InvalidOperationException("Стек пуст");
        var temp = _head;
        _head = _head.Next;
        Count--;
        return temp.Data;
    }

    public T Peek()
    {
        if (IsEmpty()) throw new InvalidOperationException("Стек пуст");
        return _head.Data;
    }

    public IEnumerator<T> GetEnumerator()
    {
        var current = _head;
        while (current != null)
        {
            yield return current.Data;
            current = current.Next;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return ((IEnumerable)this).GetEnumerator();
    }
}
