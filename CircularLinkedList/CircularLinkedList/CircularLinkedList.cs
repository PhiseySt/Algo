using System.Collections;

namespace CircularLinkedList;

public class CircularLinkedList<T>: IEnumerable<T>
{
    Node<T>? _head;
    Node<T>? _tail;
    public int Count { get; private set; }

    public void Add(T data)
    {
        var node = new Node<T>(data);
  
        if (_head == null)
        {
            _head = node;
            _tail = node;
            _tail.Next = _head;
        }
        else
        {
            node.Next = _head;
            _tail.Next = node;
            _tail = node;
        }
        Count++;
    }

    public bool Remove(T data)
    {
        Node<T>? current = _head;
        Node<T>? previous = null;

        if (IsEmpty()) return false;

        do
        {
            if (current.Data.Equals(data))
            {
    
                if (previous != null)
                {

                    previous.Next = current.Next;

                    if (current == _tail)
                        _tail = previous;
                }
                else 
                {

                    if (Count == 1)
                    {
                        _head = _tail = null;
                    }
                    else
                    {
                        _head = current.Next;
                        _tail.Next = current.Next;
                    }
                }
                Count--;
                return true;
            }

            previous = current;
            current = current.Next;
        } while (current != _head);

        return false;
    }

    public bool IsEmpty() => Count == 0;

    public void Clear()
    {
        _head = null;
        _tail = null;
        Count = 0;
    }

    public bool Contains(T data)
    {
        var current = _head;
        if (current == null) return false;
        do
        {
            if (current.Data.Equals(data))
                return true;
            current = current.Next;
        }
        while (current != _head);
        return false;
    }


    public IEnumerator<T> GetEnumerator()
    {
        var current = _head;
        do
        {
            if (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }
        while (current != _head);
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}