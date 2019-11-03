using System;

namespace FactoryMethod
{
  public class XiaomiSmartphone : ISmartphone
  {
    public void Call(string mobileNumber)
    {
      Console.WriteLine($"{nameof(XiaomiSmartphone)}: call a number '{mobileNumber}' ...");
    }
  }
}
