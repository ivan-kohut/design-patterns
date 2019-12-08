namespace Strategy
{
  public class Program
  {
    static void Main(string[] args)
    {
      Context context = new Context(new AddStrategy());

      context.DoMainWork();

      context.Strategy = new MultiplyStrategy();

      context.DoMainWork();
    }
  }
}
