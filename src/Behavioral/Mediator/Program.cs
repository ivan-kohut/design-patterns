using System;

namespace Mediator
{
  class Program
  {
    static void Main(string[] args)
    {
      FirstComponent firstComponent = new FirstComponent();
      SecondComponent secondComponent = new SecondComponent();

      IMediator mediator = new Mediator(firstComponent, secondComponent);

      firstComponent.FirstImportantWork();

      Console.WriteLine("-----------");

      secondComponent.FirstImportantWork();
    }
  }
}
