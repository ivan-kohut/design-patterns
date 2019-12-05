using System;

namespace Mediator
{
  public class FirstComponent : ComponentBase
  {
    public void FirstImportantWork()
    {
      Console.WriteLine("It is just first important work from first component..");

      Mediator.Notify($"{nameof(FirstComponent)} + {nameof(FirstImportantWork)}");
    }

    public void SecondImportantWork()
    {
      Console.WriteLine("It is just second important work from first component..");

      Mediator.Notify($"{nameof(FirstComponent)} + {nameof(SecondImportantWork)}");
    }
  }
}
