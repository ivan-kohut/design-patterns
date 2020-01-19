using System;
using System.Collections.Generic;

namespace Interpreter
{
  public static class ExpressionBuilder
  {
    public static IExpression Build(this string expression)
    {
      Stack<IExpression> expressionStack = new Stack<IExpression>();

      foreach (string value in expression.Split(" "))
      {
        IExpression resultExpression;

        if (int.TryParse(value, out int number))
        {
          resultExpression = new TerminalExpression(number);
        }
        else
        {
          IExpression secondExpression = expressionStack.Pop();
          IExpression firstExpression = expressionStack.Pop();

          resultExpression = value switch
          {
            "+" => new AddExpression(firstExpression, secondExpression),
            "-" => new SubtractExpression(firstExpression, secondExpression),
            "*" => new MultiplyExpression(firstExpression, secondExpression),
            "/" => new DivideExpression(firstExpression, secondExpression),
            _ => throw new Exception("Invalid operation")
          };
        }

        expressionStack.Push(resultExpression);
      }

      return expressionStack.Pop();
    }
  }
}
