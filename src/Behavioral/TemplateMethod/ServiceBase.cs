namespace TemplateMethod
{
  public abstract class ServiceBase : IService
  {
    public void DoComplexWork()
    {
      FirstAlgorithmPart();
      SecondAlgorithmPart();
    }

    protected abstract void FirstAlgorithmPart();
    protected abstract void SecondAlgorithmPart();
  }
}
