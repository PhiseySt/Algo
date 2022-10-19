namespace ArrayStack;

public class ArrayStack<T>
{
    private T[] _items;
    public int Count { get; set; }
    private const int ItemsDefaultLength = 10;

    public ArrayStack()
    {
        _items = new T[ItemsDefaultLength];
    }

    public ArrayStack(int userLength)
    {
        _items = new T[userLength];
    }

    public bool IsEmpty() => Count == 0;

    public void Push(T item)
    {
        if (Count == _items.Length)
        {
            Resize(_items.Length + 10);
        }

        _items[Count++] = item;
    }

    private void Resize(int newLength)
    {
        var newItems = new T[newLength];
        for (var i = 0; i < Count; i++)
        {
            newItems[i]= _items[i];
        }
        _items = newItems;
    }

    public T Pop()
    {
        if (IsEmpty()) throw new InvalidOperationException("Стек пуст");
        T item = _items[--Count];
        _items[Count] = default;
        if (Count > 0 && Count < _items.Length - 10)
        {
            Resize(_items.Length - 10);
        }
        return item;
    }

    public T Peek()
    {
        return _items[Count - 1];
    }
}