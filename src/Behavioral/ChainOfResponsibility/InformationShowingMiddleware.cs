using System;

namespace ChainOfResponsibility
{
  public class InformationShowingMiddleware : MiddlewareBase
  {
    public InformationShowingMiddleware(IMiddleware next = null) : base(next)
    {
    }

    public override void Invoke(Context context)
    {
      if (context.User == null)
      {
        Console.WriteLine("Can not show user info because the user does not exist..");
      }
      else
      {
        Console.WriteLine($"User: id = {context.User.Id}, first name = {context.User.FirstName}");
      }
    }
  }
}
