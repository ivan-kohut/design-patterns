using System;

namespace Prototype
{
  class Program
  {
    static void Main(string[] args)
    {
      Shape circle = new Circle(0, 0, 5);
      Shape rectangle = new Rectangle(5, 0, 2, 3);

      Shape clonedCircle = circle.Clone();
      Shape clonedRectanle = rectangle.Clone();

      Console.WriteLine(circle == clonedCircle);

      circle.Show();
      clonedCircle.Show();

      Console.WriteLine(rectangle == clonedRectanle);

      rectangle.Show();
      clonedRectanle.Show();
    }
  }
}
