using System;

namespace FactoryMethod
{
  public abstract class SmartphoneCreator
  {
    public abstract ISmartphone Create();

    public void Process()
    {
      Console.Write("Enter a mobile phone: ");

      Create().Call(Console.ReadLine());
    }
  }
}
