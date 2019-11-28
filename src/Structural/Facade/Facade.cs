namespace Facade
{
  public class Facade
  {
    private readonly FirstComplexSystem firstComplexSystem;
    private readonly SecondComplexSystem secondComplexSystem;

    public Facade (FirstComplexSystem firstComplexSystem, SecondComplexSystem secondComplexSystem)
    {
      this.firstComplexSystem = firstComplexSystem;
      this.secondComplexSystem = secondComplexSystem;
    }

    public void DoSomeImportantWork()
    {
      firstComplexSystem.ShowLight();
      secondComplexSystem.PlayMusic();
    }
  }
}
