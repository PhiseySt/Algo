using System.Collections;

namespace LinkedList;

public class LinkedList<T> : IEnumerable<T>
{
    private Node<T>? _head;
    private Node<T>? _tail;
    private int _count;

    public void Add(T data)
    {
        var node = new Node<T>(data);

        if (_head == null)
            _head = node;
        else
            _tail!.Next = node;
        _tail = node;

        _count++;
    }

    public bool Remove(T data)
    {
        var current = _head;
        Node<T>? previous = null;

        while (current != null)
        {
            if (current.Data != null && current.Data.Equals(data))
            {
                if (previous != null)
                {

                    previous.Next = current.Next;

                    if (current.Next == null)
                        _tail = previous;
                }
                else
                {
                    _head = _head?.Next;

                    if (_head == null)
                        _tail = null;
                }
                _count--;
                return true;
            }

            previous = current;
            current = current.Next;
        }
        return false;
    }

    public int Count => _count;

    public bool IsEmpty => _count == 0;


    public void Clear()
    {
        _head = null;
        _tail = null;
        _count = 0;
    }

    public bool Contains(T data)
    {
        var current = _head;
        while (current != null)
        {
            if (current.Data != null && current.Data.Equals(data))
                return true;
            current = current.Next;
        }
        return false;
    }

    public void AddFirst(T data)
    {
        var node = new Node<T>(data)
        {
            Next = _head
        };
        _head = node;
        if (_count == 0)
            _tail = _head;
        _count++;
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return ((IEnumerable)this).GetEnumerator();
    }

    IEnumerator<T> IEnumerable<T>.GetEnumerator()
    {
        var current = _head;
        while (current != null)
        {
            yield return current.Data;
            current = current.Next;
        }
    }
}