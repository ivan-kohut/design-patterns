using System;

namespace AbstractFactory
{
  public class KindDefender : IDefender
  {
    public void Defend() => Console.WriteLine("Defending of kind character");
  }
}
