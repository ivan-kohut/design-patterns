using System;

namespace Observer
{
  public class ConsoleObserver : IObserver
  {
    public void Update(string state) => Console.WriteLine($"Console has got state: {state}");
  }
}
