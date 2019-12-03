using System.Collections.Generic;

namespace Iterator
{
  public class IterableList<T> : IIterableCollection<T>
  {
    private readonly List<T> items;

    public IterableList()
    {
      this.items = new List<T>();
    }

    public T this[int index] => items[index];

    public int Count => items.Count;

    public void Add(T item) => items.Add(item);

    public IAppEnumerator<T> GetEnumerator() => new IterableListEnumerator<T>(this);
  }
}
