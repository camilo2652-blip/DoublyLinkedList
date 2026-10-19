

using System.Runtime.InteropServices;

namespace Backend;

public class DoublyLinkedList<T> where T : IComparable<T>
{
    private DoubleNode<T>? _head;
    private DoubleNode<T>? _tail;
    public DoublyLinkedList()
    {
        _head = null;
        _tail = null;
    }
    public void AddOrder(T data)
    {
        var newNode = new DoubleNode<T>(data);
        if (_head == null)
        {
            _head = newNode;
            _tail = newNode;
            return;
        }
        if (CompareValues(data, _head.Data!) <= 0)
        {
            newNode.Next = _head;
            _head.Prev = newNode;
            _head = newNode;
            return;
        }
        if (CompareValues(data, _tail!.Data!) >= 0)
        {
            _tail.Next = newNode;
            newNode.Prev = _tail;
            _tail = newNode;
            return;
        }
        var current = _head;
        while (current.Next != null && CompareValues(current.Next.Data!, data) < 0)
        {
            current = current.Next;
        }
        newNode.Next = current.Next;
        newNode.Prev = current;
        current.Next!.Prev = newNode;
        current.Next = newNode;
    }
    private int CompareValues(T x, T y)
    {
        string strX = x?.ToString() ?? string.Empty;
        string strY = y?.ToString() ?? string.Empty;

        if (double.TryParse(strX, out double numX) && double.TryParse(strY, out double numY))
        {
            return numX.CompareTo(numY);
        }
        return strX.CompareTo(strY);
    }
    public bool Contains(T data)
    {
        var current = _head;
        while (current != null)
        {
            if (current.Data!.Equals(data))
            {
                return true;
            }
            current = current.Next;
        }
        return false;
    }

    public override string ToString()
    {
        var output = string.Empty;
        var current = _head;
        while (current != null)
        {
            output += $"{current.Data} <-> ";
            current = current.Next;
        }
        return $"{output} null";
    }

    public string ToStringReverse()
    {
        var output = string.Empty;
        var current = _tail;
        while (current != null)
        {
            output += $"{current.Data} <-> ";
            current = current.Prev;
        }
        return $"{output} null";
    }



    public void Remove(T data)
    {
        var current = _head;
        while (current != null)
        {
            if (current.Data!.Equals(data))
            {
                if (current == _head && current == _tail)
                {
                    _head = null;
                    _tail = null;
                }
                else if (current == _head)
                {
                    _head = _head.Next;
                    _head!.Prev = null;
                }
                else if (current == _tail)
                {
                    _tail = _tail.Prev;
                    _tail!.Next = null;
                }
                else
                {
                    current.Prev!.Next = current.Next;
                    current.Next!.Prev = current.Prev;
                }
                return;
            }
            current = current.Next;
        }
    }

    public void ReverseLinks()
    {
        if (_head == null || _head == _tail) return;

        var current = _head;
        DoubleNode<T>? temp = null;
        while (current != null)
        {
            temp = current.Prev;
            current.Prev = current.Next;
            current.Next = temp;
            current = current.Prev;
        }
        temp = _head;
        _head = _tail;
        _tail = temp;  
    }



}




