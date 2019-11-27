namespace Decorator
{
  public abstract class UserRepositoryDecorator : IUserRepository
  {
    private readonly IUserRepository userRepository;

    public UserRepositoryDecorator(IUserRepository userRepository)
    {
      this.userRepository = userRepository;
    }

    public virtual User GetUserById(int id) => userRepository.GetUserById(id);
  }
}
