namespace Iterator
{
  public interface IAppEnumerator<T>
  {
    T Current { get; }

    bool MoveNext();
  }
}
