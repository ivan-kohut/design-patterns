namespace Command
{
  public class Button
  {
    private readonly ICommand command;

    public Button(ICommand command)
    {
      this.command = command;
    }

    public void Click() => command.Execute();
  }
}
