using System;
using System.Collections.Generic;

namespace Proxy
{
  public class CachedUserRepository : IUserRepository
  {
    private readonly IUserRepository userRepository;

    private readonly IDictionary<int, User> cachedUsers;

    public CachedUserRepository(IUserRepository userRepository)
    {
      this.userRepository = userRepository;
      this.cachedUsers = new Dictionary<int, User>();
    }

    public User GetUserById(int id)
    {
      if (cachedUsers.TryGetValue(id, out User user))
      {
        Console.WriteLine($"User with id {id} is from cache");

        return user;
      }
      else
      {
        user = userRepository.GetUserById(id);

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

