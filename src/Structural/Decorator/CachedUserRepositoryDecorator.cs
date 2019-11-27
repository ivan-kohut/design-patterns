using System;
using System.Collections.Generic;

namespace Decorator
{
  public class CachedUserRepositoryDecorator : UserRepositoryDecorator
  {
    private readonly IDictionary<int, User> cachedUsers;

    public CachedUserRepositoryDecorator(IUserRepository userRepository) : base(userRepository)
    {
      cachedUsers = new Dictionary<int, User>();
    }

    public override User GetUserById(int id)
    {
      if (cachedUsers.TryGetValue(id, out User user))
      {
        Console.WriteLine($"User with id {id} is from cache");

        return user;
      }
      else
      {
        user = base.GetUserById(id);

        if (user != null)
        {
          Console.WriteLine($"User with id {id} was added to cache");

          cachedUsers.Add(id, user);
        }

        return user;
      }
    }
  }
}
