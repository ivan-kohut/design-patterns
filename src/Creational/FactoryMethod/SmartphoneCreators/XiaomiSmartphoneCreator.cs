namespace FactoryMethod
{
  public class XiaomiSmartphoneCreator : SmartphoneCreator
  {
    public override ISmartphone Create() => new XiaomiSmartphone();
  }
}
