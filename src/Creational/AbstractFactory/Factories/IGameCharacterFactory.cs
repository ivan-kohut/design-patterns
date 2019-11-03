namespace AbstractFactory
{
  public interface IGameCharacterFactory
  {
    IAttacker CreateAttacker();
    IDefender CreateDefender();
  }
}
