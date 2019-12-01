using System;

namespace ChainOfResponsibility
{
  public class LoggingMiddleware : MiddlewareBase
  {
    public LoggingMiddleware(IMiddleware next = null) : base(next)
    {
    }

    public override void Invoke(Context context)
    {
      Console.WriteLine($"Context with authentication cookie: {context.AuthCookie}");

      base.Invoke(context);
    }
  }
}
