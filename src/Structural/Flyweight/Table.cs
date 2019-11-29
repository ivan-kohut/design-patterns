using System.Collections.Generic;

namespace Flyweight
{
  public class Table
  {
    private readonly CubeTypeFactory cubeTypeFactory;
    private readonly ICollection<Cube> cubes;

    public Table(CubeTypeFactory cubeTypeFactory)
    {
      this.cubeTypeFactory = cubeTypeFactory;
      this.cubes = new List<Cube>();
    }

    public void AddCube(int number, int edgeLength, string color) =>
      cubes.Add(new Cube(number, cubeTypeFactory.GetCubeType(edgeLength, color)));

    public void ShowCubes()
    {
      foreach (Cube cube in cubes)
      {
        cube.Show();
      }
    }
  }
}
