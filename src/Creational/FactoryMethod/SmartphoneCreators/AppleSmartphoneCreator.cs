namespace FactoryMethod
{
  public class AppleSmartphoneCreator : SmartphoneCreator
  {
    public override ISmartphone Create() => new AppleSmartphone();
  }
}
