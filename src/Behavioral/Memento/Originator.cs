using System;

namespace Memento
{
  public class Originator : IOriginator
  {
    public int IntState { private get; set; }
    public string StringState { private get; set; }

    public Originator(int intState, string stringState)
    {
      this.IntState = intState;
      this.StringState = stringState;
    }

    public IMemento Save() => new Memento(this, IntState, StringState);

    public void ShowValues() => Console.WriteLine($"{IntState} + {StringState}");

    public void ResetValues()
    {
      IntState = new Random().Next();
      StringState = DateTimeOffset.UtcNow.Millisecond.ToString();
    }
  }
}
