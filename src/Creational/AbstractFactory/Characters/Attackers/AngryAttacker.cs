using System;

namespace AbstractFactory
{
  public class AngryAttacker : IAttacker
  {
    public void Attack() => Console.WriteLine("Attacking of angry character");
  }
}
