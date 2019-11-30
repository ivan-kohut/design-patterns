namespace Proxy
{
  public class Program
  {
    static void Main(string[] args)
    {
      IUserRepository userRepository = new UserRepository();
      IUserRepository cachedUserRepository = new CachedUserRepository(userRepository);

      for (int i = 0; i < 5; i++)
      {
        User firstCall = cachedUserRepository.GetUserById(i);
        User secondCall = cachedUserRepository.GetUserById(i);
      }
    }
  }
}
