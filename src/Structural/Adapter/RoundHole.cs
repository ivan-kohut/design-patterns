namespace Adapter
{
  public class RoundHole
  {
    public double Radius { get; }

    public RoundHole(double radius)
    {
      this.Radius = radius;
    }

    public bool Fits(IRoundable roundPeg) => Radius >= roundPeg.Radius;
  }
}
