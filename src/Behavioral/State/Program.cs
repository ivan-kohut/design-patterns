namespace State
{
  public class Program
  {
    static void Main(string[] args)
    {
      Player player = new Player();

      player.ClickPlay(); // start
      player.ClickPlay(); // stop

      player.ClickPlay(); // start
      player.ClickNext();

      player.ClickLock();
      player.ClickPrevious();

      player.ClickLock();
      player.ClickPlay();
    }
  }
}
