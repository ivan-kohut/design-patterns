namespace Flyweight
{
  public class Program
  {
    static void Main(string[] args)
    {
      CubeTypeFactory cubeTypeFactory = new CubeTypeFactory();

      Table table = new Table(cubeTypeFactory);

      table.AddCube(1, 1, "blue");
      table.AddCube(2, 1, "blue");
      table.AddCube(3, 2, "red");
      table.AddCube(4, 2, "red");
      table.AddCube(5, 3, "green");

      table.ShowCubes();

      cubeTypeFactory.ListCubeTypes();
    }
  }
}
