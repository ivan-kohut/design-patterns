namespace Memento
{
  public interface IOriginator
  {
    IMemento Save();
    void ResetValues();
    void ShowValues();
  }
}
