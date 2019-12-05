namespace Memento
{
  public class Memento : IMemento
  {
    private readonly Originator originator;

    private readonly int intState;
    private readonly string stringState;

    public Memento(Originator originator, int intState, string stringState)
    {
      this.originator = originator;
      this.intState = intState;
      this.stringState = stringState;
    }
    public void Restore()
    {
      originator.IntState = intState;
      originator.StringState = stringState;
    }
  }
}
