namespace Flyweight
{
  public class Cube
  {
    public int Number { get; }
    public CubeType CubeType { get; }

    public Cube(int number, CubeType cubeType)
    {
      this.Number = number;
      this.CubeType = cubeType;
    }

    public void Show() => CubeType.Show(Number);
  }
}
