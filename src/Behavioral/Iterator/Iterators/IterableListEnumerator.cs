namespace Iterator
{
  public class IterableListEnumerator<T> : IAppEnumerator<T>
  {
    private int position;
    private readonly IterableList<T> iterableList;

    public IterableListEnumerator(IterableList<T> iterableList)
    {
      this.position = -1;
      this.iterableList = iterableList;
    }

    public T Current => IsInRange ? iterableList[position] : default;

    public bool MoveNext()
    {
      position++;

      return IsInRange;
    }

    private bool IsInRange => 0 <= position && position < iterableList.Count;
  }
}
