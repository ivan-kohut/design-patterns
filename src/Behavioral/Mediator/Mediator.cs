namespace Mediator
{
  public class Mediator : IMediator
  {
    private readonly FirstComponent firstComponent;
    private readonly SecondComponent secondComponent;

    public Mediator(FirstComponent firstComponent, SecondComponent secondComponent)
    {
      this.firstComponent = firstComponent;
      this.secondComponent = secondComponent;

      this.firstComponent.Mediator = this.secondComponent.Mediator = this;
    }

    public void Notify(string currentOperation)
    {
      if (currentOperation == $"{nameof(FirstComponent)} + {nameof(FirstComponent.FirstImportantWork)}")
      {
        secondComponent.SecondImportantWork();
      }
      else if (currentOperation == $"{nameof(SecondComponent)} + {nameof(FirstComponent.FirstImportantWork)}")
      {
        firstComponent.FirstImportantWork();
        firstComponent.SecondImportantWork();
      }
    }
  }
}
