namespace Builder
{
  public class CountryHouseBuilder : IHouseBuilder
  {
    private House house;

    public CountryHouseBuilder()
    {
      Reset();
    }

    public void BuildDoors() => house.Doors = 1;

    public void BuildFoundation() => house.IsFoundationBuilt = true;

    public void BuildRoof() => house.IsRoofBuilt = true;

    public void BuildWalls() => house.Walls = 4;

    public void BuildWindows() => house.Windows = 1;

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
