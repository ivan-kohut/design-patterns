namespace Prototype
{
  public abstract class Shape
  {
    public int X { get; set; }
    public int Y { get; set; }

    protected Shape(int x, int y)
    {
      this.X = x;
      this.Y = y;
    }

    protected Shape(Shape shape) : this(shape.X, shape.Y)
    {
    }

    public abstract Shape Clone();
    public abstract void Show();
  }
}
