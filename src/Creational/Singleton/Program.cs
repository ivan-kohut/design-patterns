using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Singleton
{
  public class Program
  {
    static async Task Main(string[] args)
    {
      IEnumerable<Task<AppConfig>> appConfigTasks = Enumerable.Range(0, 100)
        .Select(i => Task.Run(() => AppConfig.Instance))
        .ToList();

      IEnumerable<AppConfig> appConfigs = await Task.WhenAll(appConfigTasks);

      bool isSingleton = true;

      AppConfig first = appConfigs.First();

      foreach (AppConfig appConfig in appConfigs)
      {
        isSingleton = isSingleton && first == appConfig;
      }

      Console.WriteLine(isSingleton);
    }
  }
}
