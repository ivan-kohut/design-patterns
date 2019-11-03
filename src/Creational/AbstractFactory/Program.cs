using System.Linq;

namespace AbstractFactory
{
  public class Program
  {
    static void Main(string[] args)
    {
      new IGameCharacterFactory[]
      {
        new KindGameCharacterFactory(),
        new AngryGameCharacterFactory()
      }
      .ToList()
      .ForEach(CreateCharacters);
    }

    private static void CreateCharacters(IGameCharacterFactory factory)
    {
      factory.CreateAttacker().Attack();
      factory.CreateDefender().Defend();
    }
  }
}
