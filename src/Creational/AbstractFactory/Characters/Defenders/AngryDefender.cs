using System;

namespace AbstractFactory
{
  public class AngryDefender : IDefender
  {
    public void Defend() => Console.WriteLine("Defending of angry character");
  }
}
