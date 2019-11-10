namespace Singleton
{
  public class AppConfig
  {
    static AppConfig()
    {
    }

    private AppConfig()
    {
    }

    public static AppConfig Instance { get; } = new AppConfig();
  }
}
