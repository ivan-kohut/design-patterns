using System;

namespace Prototype
{
  public class Circle : Shape
  {
    public int Radius { get; set; }

    public Circle(int x, int y, int radius) : base(x, y)
    {
      this.Radius = radius;
    }

    private Circle(Circle circle) : base(circle)
    {
      this.Radius = circle.Radius;
    }

    public override Shape Clone() => new Circle(this);

    public override void Show()
    {
      Console.WriteLine($"{nameof(X)}: {X}");
      Console.WriteLine($"{nameof(Y)}: {Y}");
      Console.WriteLine($"{nameof(Radius)}: {Radius}");
    }
  }
}
