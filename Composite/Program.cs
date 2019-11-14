namespace Composite
{
  public class Program
  {
    static void Main(string[] args)
    {
      Gift phone = new Product("Phone XYZ");
      Gift mp3 = new Product("MP3 player");

      Gift firstBox = new Box { phone, mp3 };

      Gift tv = new Product("TV JJJ");
      Gift laptop = new Product("Laptop");

      Gift secondBox = new Box { tv, laptop };

      Gift pot = new Product("Pot");

      Gift mainBox = new Box { firstBox, secondBox, pot };

      mainBox.Show();
    }
  }
}
