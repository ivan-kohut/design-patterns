using System;
using System.Collections.Generic;
using System.Linq;

namespace Flyweight
{
  public class CubeTypeFactory
  {
    private readonly ICollection<CubeType> cachedCubeTypes;
    
    public CubeTypeFactory()
    {
      this.cachedCubeTypes = new List<CubeType>();
    }

    public CubeType GetCubeType(int edgeLength, string color)
    {
      CubeType result = cachedCubeTypes
        .Where(t => t.EdgeLength == edgeLength && t.Color == color)
        .SingleOrDefault();

      if (result == default)
      {
        result = new CubeType(edgeLength, color);

        cachedCubeTypes.Add(result);
      }

      return result;
    }

    public void ListCubeTypes()
    {
      Console.WriteLine($"Total: {cachedCubeTypes.Count()}");
      Console.WriteLine();

      foreach (CubeType cubeType in cachedCubeTypes)
      {
        Console.WriteLine("Cube type info:");
        Console.WriteLine($"Edge length => {cubeType.EdgeLength}");
        Console.WriteLine($"Color => {cubeType.Color}");
        Console.WriteLine();
      }
    }
  }
}
