using System;

namespace Adapter
{
  public class SquarePegAdapter : IRoundable
  {
    private readonly SquarePeg squarePeg;

    public SquarePegAdapter(SquarePeg squarePeg)
    {
      this.squarePeg = squarePeg;
    }

    public double Radius => squarePeg.Width * Math.Sqrt(2) / 2;
  }
}
