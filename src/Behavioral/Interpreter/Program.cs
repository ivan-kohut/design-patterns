using System;

namespace Interpreter
{
  public class Program
  {
    static void Main(string[] args)
    {
      string expression = "15 7 1 1 + - / 3 * 2 1 1 + + -";

      IExpression builtExpression = expression.Build();

      Console.WriteLine(builtExpression.Interpret());
    }
  }
}
