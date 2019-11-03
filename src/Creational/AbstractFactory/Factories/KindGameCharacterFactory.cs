namespace AbstractFactory
{
  public class KindGameCharacterFactory : IGameCharacterFactory
  {
    public IAttacker CreateAttacker() => new KindAttacker();

    public IDefender CreateDefender() => new KindDefender();
  }
}
