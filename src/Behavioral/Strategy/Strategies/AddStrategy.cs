namespace Strategy
{
  public class AddStrategy : IStrategy
  {
    public int Calculate(int a, int b) => a + b;
  }
}
