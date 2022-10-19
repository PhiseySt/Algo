using System.Collections;

namespace DoublyLinkedList;

public class DoublyLinkedList<T> : IEnumerable<T>
{
    private DoublyNode<T>? _head;
    private DoublyNode<T>? _tail;
    public int Count { get; private set; }

    public void Add(T data)
    {
        var node = new DoublyNode<T>(data);

        if (_head == null)
            _head = node;
        else
        {
            _tail.Next = node;
            node.Previous = _tail;
        }
        _tail = node;
        Count++;
    }

    public void AddFirst(T data)
    {
        var node = new DoublyNode<T>(data);
        var temp = _head;
        node.Next = temp;
        _head = node;
        if (Count == 0)
            _tail = _head;
        else
            temp.Previous = node;
        Count++;
    }

    public bool IsEmpty => Count == 0;

    public void Clear()
    {
        _head = null;
        _tail = null;
        Count = 0;
    }

    public bool Contains(T data)
    {
        var current = _head;
        while (current != null)
        {
            if (current.Data.Equals(data))
                return true;
            current = current.Next;
        }
        return false;
    }

    public bool Remove(T data)
    {
        var current = _head;

        // поиск удаляемого узла
        while (current != null)
        {
            if (current.Data != null && current.Data.Equals(data))
            {
                break;
            }
            current = current.Next;
        }
        if (current != null)
        {
            if (current.Next != null)
            {
                current.Next.Previous = current.Previous;
            }
            else
            {
                _tail = current.Previous;
            }

            if (current.Previous != null)
            {
                current.Previous.Next = current.Next;
            }
            else
            {
                _head = current.Next;
            }
            Count--;
            return true;
        }
        return false;
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

    public IEnumerable<T> BackEnumerator()
    {
        var current = _tail;
        while (current != null)
        {
            yield return current.Data;
            current = current.Previous;
        }
    }
}