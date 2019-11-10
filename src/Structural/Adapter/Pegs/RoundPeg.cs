namespace Adapter
{
  public class RoundPeg : IRoundable
  {
    public double Radius { get; }

    public RoundPeg(double radius)
    {
      this.Radius = radius;
    }
  }
}
