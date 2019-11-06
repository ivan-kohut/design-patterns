namespace Builder
{
  public class BeachHouseBuilder : IHouseBuilder
  {
    private House house;

    public BeachHouseBuilder()
    {
      Reset();
    }

    public void BuildDoors() => house.Doors = 2;

    public void BuildFoundation() => house.IsFoundationBuilt = true;

    public void BuildRoof() => house.IsRoofBuilt = true;

    public void BuildWalls() => house.Walls = 4;

    public void BuildWindows() => house.Windows = 3;

    public void Reset()
    {
      house = new House();
    }

    public House GetHouse()
    {
      House result = house;

      Reset();

      return result;
    }
  }
}
