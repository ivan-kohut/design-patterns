namespace ChainOfResponsibility
{
  public class Context
  {
    public Context(string authCookie)
    {
      this.AuthCookie = authCookie;
    }

    public string AuthCookie { get; }
    public User User { get; set; }
  }

  public class User
  {
    public int Id { get; set; }
    public string FirstName { get; set; }
  }
}
