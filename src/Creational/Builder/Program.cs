namespace Builder
{
  public class Program
  {
    static void Main(string[] args)
    {
      Director director = new Director();

      CountryHouseBuilder countryHouseBuilder = new CountryHouseBuilder();

      director.HouseBuilder = countryHouseBuilder;
      director.BuildHouse();

      House countryHouse = countryHouseBuilder.GetHouse();
      countryHouse.Show();

      BeachHouseBuilder beachHouseBuilder = new BeachHouseBuilder();

      director.HouseBuilder = beachHouseBuilder;
      director.BuildHouse();

      House beachHouse = beachHouseBuilder.GetHouse();
      beachHouse.Show();
    }
  }
}
