namespace Interpreter
{
  public class DivideExpression : IExpression
  {
    private readonly IExpression first;
    private readonly IExpression second;

    public DivideExpression(IExpression first, IExpression second)
    {
      this.first = first;
      this.second = second;
    }

    public int Interpret() => first.Interpret() / second.Interpret();
  }
}
