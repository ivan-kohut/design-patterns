using System;

namespace Prototype
{
  public class Rectangle : Shape
  {
    public int Width { get; set; }
    public int Height { get; set; }

    public Rectangle(int x, int y, int width, int height) : base(x, y)
    {
      this.Width = width;
      this.Height = height;
    }

    private Rectangle(Rectangle rectangle) : base(rectangle)
    {
      this.Width = rectangle.Width;
      this.Height = rectangle.Height;
    }

    public override Shape Clone() => new Rectangle(this);

    public override void Show()
    {
      Console.WriteLine($"{nameof(X)}: {X}");
      Console.WriteLine($"{nameof(Y)}: {Y}");
      Console.WriteLine($"{nameof(Width)}: {Width}");
      Console.WriteLine($"{nameof(Height)}: {Height}");
    }
  }
}
