using System;

namespace Flyweight
{
  public class CubeType
  {
    public int EdgeLength { get; }
    public string Color { get; }

    public CubeType(int edgeLength, string color)
    {
      this.EdgeLength = edgeLength;
      this.Color = color;
    }

    public void Show(int number)
    {
      Console.WriteLine("Cube info:");
      Console.WriteLine($"Number => {number}");
      Console.WriteLine($"Edge length => {EdgeLength}");
      Console.WriteLine($"Color => {Color}");
      Console.WriteLine();
    }
  }
}
