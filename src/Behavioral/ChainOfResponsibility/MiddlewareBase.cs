namespace ChainOfResponsibility
{
  public abstract class MiddlewareBase : IMiddleware
  {
    private readonly IMiddleware next;

    protected MiddlewareBase(IMiddleware next = null)
    {
      this.next = next;
    }

    public virtual void Invoke(Context context)
    {
      if (next != null)
      {
        next.Invoke(context);
      }
    }
  }
}
