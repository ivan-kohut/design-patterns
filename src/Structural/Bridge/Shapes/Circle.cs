using System;

namespace Bridge
{
  public class Circle : Shape
  {
    public Circle(Color color) : base(color)
    {
    }

    public override void Draw() =>
      Console.WriteLine($"Drawing the circle with {color.HexValue} color");
  }
}
