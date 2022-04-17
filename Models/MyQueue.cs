using System;
namespace dotnet6.Models;

public class MyQueue<T>
{
	private readonly object sync = new object();
	private readonly IList<T> _inner = new List<T>();

	public void Enqueue(T value)
    {
        lock (sync)
        {
            _inner.Add(value);
        }
    }

    public T Dequeue()
    {
        T last = default;
        if(_inner.Count > 0)
        {
            lock(sync)
            {
                last = _inner.Last();
                _inner.RemoveAt(_inner.Count - 1);
            }
        }

        return last;
    }

    public void Clear()
    {
        lock(sync)
        {
            _inner.Clear();
        }
    }

    public int Count => _inner.Count;

    public IEnumerable<T> Items => _inner;
}

