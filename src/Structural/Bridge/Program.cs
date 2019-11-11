namespace Bridge
{
  public class Program
  {
    static void Main(string[] args)
    {
      Color blue = new BlueColor();
      Color white = new WhiteColor();

      Shape blueCircle = new Circle(blue);
      Shape whiteCircle = new Circle(white);

      blueCircle.Draw();
      whiteCircle.Draw();

      Shape blueSquare = new Square(blue);
      Shape whiteSquare = new Square(white);

      blueSquare.Draw();
      whiteSquare.Draw();
    }
  }
}
