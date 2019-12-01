using System;
using System.Linq;

namespace ChainOfResponsibility
{
  public class AuthenticationMiddleware : MiddlewareBase
  {
    public AuthenticationMiddleware(IMiddleware next = null) : base(next)
    {
    }

    public override void Invoke(Context context)
    {
      if (context.AuthCookie.Contains(" - "))
      {
        string[] userValues = context.AuthCookie.Split(" - ");

        context.User = new User
        {
          Id = int.Parse(userValues.First()),
          FirstName = userValues.Last()
        };

        Console.WriteLine($"User is authenticated..");
      }
      else
      {
        Console.WriteLine("Bad credentials");
      }

      base.Invoke(context);
    }
  }
}
