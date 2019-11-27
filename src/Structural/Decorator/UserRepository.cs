using System.Collections.Generic;
using System.Linq;

namespace Decorator
{
  public class UserRepository : IUserRepository
  {
    private readonly IEnumerable<User> users;

    public UserRepository()
    {
      users = new List<User>
      {
        new User { Id = 1 },
        new User { Id = 2 },
        new User { Id = 3 }
      };
    }

    public User GetUserById(int id) => users.SingleOrDefault(u => u.Id == id);
  }
}
