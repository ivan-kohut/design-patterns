using System;

namespace TemplateMethod
{
  public class SecondService : ServiceBase
  {
    protected override void FirstAlgorithmPart() => Console.WriteLine($"First part of {nameof(SecondService)}");

    protected override void SecondAlgorithmPart() => Console.WriteLine($"Second part of {nameof(SecondService)}");
  }
}
