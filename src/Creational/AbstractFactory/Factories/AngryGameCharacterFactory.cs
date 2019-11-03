namespace AbstractFactory
{
  public class AngryGameCharacterFactory : IGameCharacterFactory
  {
    public IAttacker CreateAttacker() => new AngryAttacker();

    public IDefender CreateDefender() => new AngryDefender();
  }
}
