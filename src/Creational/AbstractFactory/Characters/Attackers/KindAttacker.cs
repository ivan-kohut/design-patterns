using System;

namespace AbstractFactory
{
  public class KindAttacker : IAttacker
  {
    public void Attack() => Console.WriteLine("Attacking of kind character");
  }
}
