namespace Facade
{
  public class Program
  {
    static void Main(string[] args)
    {
      FirstComplexSystem firstComplexSystem = new FirstComplexSystem();
      SecondComplexSystem secondComplexSystem = new SecondComplexSystem();

      Facade facade = new Facade(firstComplexSystem, secondComplexSystem);

      facade.DoSomeImportantWork();
    }
  }
}
