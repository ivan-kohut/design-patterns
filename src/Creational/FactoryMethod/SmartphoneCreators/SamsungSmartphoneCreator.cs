namespace FactoryMethod
{
  public class SamsungSmartphoneCreator : SmartphoneCreator
  {
    public override ISmartphone Create() => new SamsungSmartphone();
  }
}
