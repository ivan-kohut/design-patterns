using System;

namespace Bridge
{
  public class Square : Shape
  {
    public Square(Color color) : base(color)
    {
    }

    public override void Draw() =>
      Console.WriteLine($"Drawing the square with {color.HexValue} color");
  }
}
