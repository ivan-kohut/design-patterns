namespace Interpreter
{
  public class MultiplyExpression : IExpression
  {
    private readonly IExpression first;
    private readonly IExpression second;

    public MultiplyExpression(IExpression first, IExpression second)
    {
      this.first = first;
      this.second = second;
    }

    public int Interpret() => first.Interpret() * second.Interpret();
  }
}
