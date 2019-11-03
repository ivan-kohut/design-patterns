using System;

namespace FactoryMethod
{
  public class AppleSmartphone : ISmartphone
  {
    public void Call(string mobileNumber)
    {
      Console.WriteLine($"{nameof(AppleSmartphone)}: call a number '{mobileNumber}' ...");
    }
  }
}
