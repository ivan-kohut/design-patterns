namespace Builder
{
  public class Director
  {
    public IHouseBuilder HouseBuilder { private get; set; }

    public void BuildHouse()
    {
      HouseBuilder.BuildFoundation();
      HouseBuilder.BuildWalls();
      HouseBuilder.BuildWindows();
      HouseBuilder.BuildDoors();
      HouseBuilder.BuildRoof();
    }
  }
}
