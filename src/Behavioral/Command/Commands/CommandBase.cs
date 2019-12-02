namespace Command
{
  public abstract class CommandBase : ICommand
  {
    protected readonly Editor editor;

    protected CommandBase(Editor editor)
    {
      this.editor = editor;
    }

    public abstract void Execute();
  }
}
