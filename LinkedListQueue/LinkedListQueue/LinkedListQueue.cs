using System.Collections;

namespace LinkedListQueue;

public class LinkedListQueue<T>: IEnumerable<T>
{
    private Node<T>? _head;
    private Node<T>? _tail;

    public int Count { get; set; }

    public void Enqueue(T data)
    {
        var node = new Node<T>(data);
        var tempNode = _tail;
        _tail = node;
        if (Count == 0) _head = _tail;
        else tempNode.Next = _tail;
        Count++;
    }

    public T Dequeue()
    {
        if (Count == 0) throw new InvalidDataException();
        var output = _head.Data;
        _head = _head.Next;
        Count--;
        return output;
    }

    public T First
    {
        get
        {
            if (IsEmpty())
                throw new InvalidOperationException();
            return _head.Data;
        }
    }

    public T Last
    {
        get
        {
            if (IsEmpty())
                throw new InvalidOperationException();
            return _tail.Data;
        }
    }

    public bool IsEmpty() => Count == 0;

    public void Clear()
    {
        Count = 0;
        _head = null;
        _tail = null;
    }

    public bool Contains(T data)
    {
        var current = _head;
        while (current != null)
        {
            if (current.Data.Equals(data)) return true;
            current = current.Next;
        }
        return false;
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
        return GetEnumerator();
    }
}