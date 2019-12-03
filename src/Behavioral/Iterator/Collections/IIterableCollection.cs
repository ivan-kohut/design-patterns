namespace Iterator
{
  public interface IIterableCollection<T>
  {
    T this[int index] { get; }

    int Count { get; }

    void Add(T item);
    IAppEnumerator<T> GetEnumerator();
  }
}
