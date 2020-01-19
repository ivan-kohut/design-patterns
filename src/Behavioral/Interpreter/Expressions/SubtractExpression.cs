namespace Interpreter
{
  public class SubtractExpression : IExpression
  {
    private readonly IExpression first;
    private readonly IExpression second;

    public SubtractExpression(IExpression first, IExpression second)
    {
      this.first = first;
      this.second = second;
    }

    public int Interpret() => first.Interpret() - second.Interpret();
  }
}
