using System;

namespace Builder
{
  public class House
  {
    public bool IsFoundationBuilt { private get; set; }
    public int Walls { private get; set; }
    public int Doors { private get; set; }
    public int Windows { private get; set; }
    public bool IsRoofBuilt { private get; set; }

    public void Show()
    {
      Console.WriteLine($"{nameof(Doors)}: {Doors}");
      Console.WriteLine($"{nameof(Walls)}: {Walls}");
      Console.WriteLine($"{nameof(Windows)}: {Windows}");
      Console.WriteLine($"{nameof(IsFoundationBuilt)}: {IsFoundationBuilt}");
      Console.WriteLine($"{nameof(IsRoofBuilt)}: {IsRoofBuilt}");
      Console.WriteLine("-----------");
    }
  }
}
