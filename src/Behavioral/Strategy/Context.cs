using System;

namespace Strategy
{
  public class Context
  {
    public IStrategy Strategy { private get; set; }

    public Context(IStrategy strategy)
    {
      this.Strategy = strategy;
    }

    public void DoMainWork() => Console.WriteLine(Strategy.Calculate(2, 5));
  }
}
