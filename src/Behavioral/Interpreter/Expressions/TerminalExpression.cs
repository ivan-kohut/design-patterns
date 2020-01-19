namespace Interpreter
{
  public class TerminalExpression : IExpression
  {
    private readonly int value;

    public TerminalExpression(int value)
    {
      this.value = value;
    }

    public int Interpret() => value;
  }
}
