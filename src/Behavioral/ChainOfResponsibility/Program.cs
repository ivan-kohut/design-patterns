using System;

namespace ChainOfResponsibility
{
  public class Program
  {
    static void Main(string[] args)
    {
      IMiddleware middleware  = new LoggingMiddleware(new AuthenticationMiddleware(new InformationShowingMiddleware()));

      Context firstContext = new Context("Just not valid cookie");
      middleware.Invoke(firstContext);

      Console.WriteLine();

      Context secondContext = new Context("10 - John");
      middleware.Invoke(secondContext);
    }
  }
}
