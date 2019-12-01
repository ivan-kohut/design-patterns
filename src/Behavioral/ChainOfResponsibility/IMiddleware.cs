namespace ChainOfResponsibility
{
  public interface IMiddleware
  {
    void Invoke(Context context);
  }
}
