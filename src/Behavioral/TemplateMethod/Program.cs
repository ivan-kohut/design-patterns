using System;

namespace TemplateMethod
{
  public class Program
  {
    static void Main(string[] args)
    {
      IService service = new FirstService();
      service.DoComplexWork();

      Console.WriteLine("----------------------");

      service = new SecondService();
      service.DoComplexWork();
    }
  }
}
