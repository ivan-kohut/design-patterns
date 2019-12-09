using System;

namespace TemplateMethod
{
  public class FirstService : ServiceBase
  {
    protected override void FirstAlgorithmPart() => Console.WriteLine($"First part of {nameof(FirstService)}");

    protected override void SecondAlgorithmPart() => Console.WriteLine($"Second part of {nameof(FirstService)}");
  }
}
