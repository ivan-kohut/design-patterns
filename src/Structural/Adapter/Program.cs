using System;

namespace Adapter
{
  public class Program
  {
    static void Main(string[] args)
    {
      RoundHole roundHole = new RoundHole(10);

      IRoundable roundPeg = new RoundPeg(11);
      SquarePeg squarePeg = new SquarePeg(14);

      IRoundable squarePegAdapter = new SquarePegAdapter(squarePeg);

      Console.WriteLine(roundHole.Fits(roundPeg));
      Console.WriteLine(roundHole.Fits(squarePegAdapter));
    }
  }
}
