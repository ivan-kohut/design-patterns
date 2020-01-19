namespace Interpreter
{
  public class AddExpression : IExpression
  {
    private readonly IExpression first;
    private readonly IExpression second;

    public AddExpression(IExpression first, IExpression second)
    {
      this.first = first;
      this.second = second;
    }

    public int Interpret() => first.Interpret() + second.Interpret();
  }
}
