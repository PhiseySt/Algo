using System.Collections;

namespace CircularDoublyLinkedList
{
    public class CircularDoublyLinkedList<T> : IEnumerable<T>
    {
        DoublyNode<T>? _head; 
        public int Count { get; set; }

        public void Add(T data)
        {
            var node = new DoublyNode<T>(data);

            if (_head == null)
            {
                _head = node;
                _head.Next = node;
                _head.Previous = node;
            }
            else
            {
                node.Previous = _head.Previous;
                node.Next = _head;
                _head.Previous.Next = node;
                _head.Previous = node;
            }
            Count++;
        }

        public bool Remove(T data)
        {
            var current = _head;

            DoublyNode<T>? removedItem = null;
            if (Count == 0) return false;

            // поиск удаляемого узла
            do
            {
                if (current.Data.Equals(data))
                {
                    removedItem = current;
                    break;
                }
                current = current.Next;
            }
            while (current != _head);

            if (removedItem != null)
            {
                
                if (Count == 1)
                    _head = null;
                else
                {
                    if (removedItem == _head)
                    {
                        _head = _head.Next;
                    }
                    removedItem.Previous.Next = removedItem.Next;
                    removedItem.Next.Previous = removedItem.Previous;
                }
                Count--;
                return true;
            }
            return false;
        }

        public bool IsEmpty() => Count == 0;

        public void Clear()
        {
            _head = null;
            Count = 0;
        }

        public bool Contains(T data)
        {
            DoublyNode<T>? current = _head;
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


        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this).GetEnumerator();
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
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
    }
}
