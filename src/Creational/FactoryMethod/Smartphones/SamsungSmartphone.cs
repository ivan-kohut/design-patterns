using System;

namespace FactoryMethod
{
  public class SamsungSmartphone : ISmartphone
  {
    public void Call(string mobileNumber)
    {
      Console.WriteLine($"{nameof(SamsungSmartphone)}: call a number '{mobileNumber}' ...");
    }
  }
}
