namespace Strategy
{
  public class MultiplyStrategy : IStrategy
  {
    public int Calculate(int a, int b) => a * b;
  }
}
