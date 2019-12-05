using System;

namespace Mediator
{
  public class SecondComponent : ComponentBase
  {
    public void FirstImportantWork()
    {
      Console.WriteLine("It is just first important work from second component..");

      Mediator.Notify($"{nameof(SecondComponent)} + {nameof(FirstImportantWork)}");
    }

    public void SecondImportantWork()
    {
      Console.WriteLine("It is just second important work from second component..");

      Mediator.Notify($"{nameof(SecondComponent)} + {nameof(SecondImportantWork)}");
    }
  }
}
